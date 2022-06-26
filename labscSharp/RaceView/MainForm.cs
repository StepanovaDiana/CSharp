using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab5;
using System.Reflection;

namespace RaceView
{
    public partial class MainForm : Form
    {
        List<DrawingObject> viewObjects;
        object viewObjectsLocker;

        List<DrawingModel> viewModels;
        object viewModelsLocker;

        Drawer painter;

        DrawingObject repairLocation, garage;

        List<Car> cars;
        object carsLocker;

        List<Mechanic> mechanics;
        object mechanicLocker;
        Race race;
        IEnumerable<Type> loaderTypes;

        List<string> messages;

        Image carImage,
            loaderImage,
            garageImage,
            raceImage,
            repairLocationImage,
            mechanicImage;

        public MainForm()
        {
            InitializeComponent();

            InitImages();

            viewObjects = new List<DrawingObject>();
            viewObjectsLocker = new object();

            viewModels = new List<DrawingModel>();
            viewModelsLocker = new object();

            cars = new List<Car>();
            carsLocker = new object();

            mechanics = new List<Mechanic>();
            mechanicLocker = new object();

            loaderTypes = Assembly.Load("RaceModel").GetTypes()
                .Where(type => !type.IsAbstract && type.GetInterface("ILoader") != null);

            messages = new List<string>();

        }

        void InitImages()
        {
            carImage = Properties.Resources.mcQueen;
            loaderImage = Properties.Resources.loader;
            garageImage = Properties.Resources.garage;
            raceImage = Properties.Resources.Race;
            repairLocationImage = Properties.Resources.Repair;
            mechanicImage = Properties.Resources.mechanic;
        }

        void Message(string message)
        {
            messageTextBox.Invoke((MethodInvoker)delegate
            {
                messages.Add(message);

                if (messages.Count >= 15)
                {
                    // clear
                    messages = messages.GetRange(5, 9);

                    messageTextBox.Text = "";

                    foreach (var item in messages)
                    {
                        messageTextBox.Text += item + "\r\n\r\n";
                    }
                }

                messageTextBox.Text += message + "\r\n\r\n";
            });
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {


            painter.Stop();

            
            race.IsCanceled = true;

            foreach (var item in viewModels)
            {
                if (item is DrawingModel viewModel)
                    viewModel.Model.IsCanceled = true;
            }
        }

        void InputPersonModel(MoveModel personModel)
        {
            Input inputName = new Input();

            if (inputName.ShowDialog() == DialogResult.OK)
            {
                personModel.Name = inputName.Value;
            }
        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Car newCar = new Car(Message, garage.X, garage.Y);

            InputPersonModel(newCar);


            lock(carsLocker)
            {
                cars.Add(newCar);
            }

            lock(viewModels)
            {
                viewModels.Add(new DrawingModel(newCar, carImage));
            }

         
            Task.Run(newCar.Start);
        }

        private void addMechanicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mechanic newMechanic = new Mechanic(Message, garage.X, garage.Y,cars,carsLocker);

            InputPersonModel(newMechanic);

            lock (carsLocker)
            {
                mechanics.Add(newMechanic);
            }

            lock (viewModels)
            {
                viewModels.Add(new DrawingModel(newMechanic, carImage));
            }

            Task.Run(newMechanic.Start);
        }

        private void addLoaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type loaderType = typeof(Loader1);

            SelectLoaderType selectLoaderType = new SelectLoaderType(loaderTypes);

            if (selectLoaderType.ShowDialog() == DialogResult.OK)
            {
                loaderType = selectLoaderType.SelectedType;
            }

            Loader loader = Activator.CreateInstance(loaderType,
                new object[] { (Action<string>)Message, repairLocation.X, repairLocation.Y, cars, carsLocker,mechanics,mechanicLocker }) as Loader;

            InputPersonModel(loader);

            lock (viewModelsLocker)
            {
                viewModels.Add(new DrawingModel(loader, loaderImage));
            }

            Task.Run(loader.Start);
        }

        void SetBuildingsSize()
        {
          
            
            repairLocation.X = pictureBox.Width - repairLocationImage.Width / 2;
            repairLocation.Y = pictureBox.Height - garageImage.Height - repairLocationImage.Height / 3;

            garage.X = pictureBox.Width - garageImage.Width / 2;
            garage.Y = pictureBox.Height - garageImage.Height / 2;
        }

        

        void GenerateCars(int carsNumber)
        {            
            for (int i = 0; i < carsNumber; i++)
            {
                var newSportsman = new Car(Message, garage.X, garage.Y)
                {
                    Name = "Болид" + i.ToString()
                };

                cars.Add(newSportsman);

                viewModels.Add(new DrawingModel(newSportsman, carImage));

                Task.Run(newSportsman.Start);
            }
        }

        void GenerateLoader(int loadersNumber)
        {
            object[] loaderArgs = new object[]
            { (Action<string>)Message,
                repairLocation.X,
                repairLocation.Y,
                cars,
                carsLocker,
                mechanics,
                mechanicLocker
            };

            for (int i = 0; i < loadersNumber; i++)
            {
                foreach (var item in loaderTypes)
                {
                    Loader newLoader = Activator.CreateInstance(item, loaderArgs) as Loader;
                    newLoader.Name = "Погрузчик" + i.ToString();

                    viewModels.Add(new DrawingModel(newLoader, loaderImage));

                    Task.Run(newLoader.Start);
                }
            }
        }

        void GenerateMechanic(int mechanicNumber)
        {
            for (int i = 0; i < mechanicNumber; i++)
            {
                var newMechanic = new Mechanic(Message, repairLocation.X, repairLocation.Y,cars,carsLocker)
                {
                    Name = "Механик" + i.ToString()
                };

                mechanics.Add(newMechanic);

                viewModels.Add(new DrawingModel(newMechanic, mechanicImage));

                Task.Run(newMechanic.Start);
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCarToolStripMenuItem.Enabled = true;
            addLoaderToolStripMenuItem.Enabled = true;
            startToolStripMenuItem.Enabled = false;

            painter = new Drawer(pictureBox, Color.FromArgb(105, 105, 105),
               new Font(messageTextBox.Font.FontFamily, 10f, messageTextBox.Font.Style),
               viewObjects, viewObjectsLocker, viewModels, viewModelsLocker);

           

            repairLocation = new DrawingObject(repairLocationImage);
            garage = new DrawingObject(garageImage);

            SetBuildingsSize();

           
            viewObjects.Add(repairLocation);
            viewObjects.Add(garage);

            float x = raceImage.Width / 2,
                y = raceImage.Height / 2;
            race = new Race(Message, cars, carsLocker, x, y);
            lock (viewObjectsLocker)
            {
                viewObjects.Add(new DrawingObject(raceImage, x, y));
            }

            Task.Run(race.Start);

            GenerateCars(8);

            GenerateLoader(2);

            GenerateMechanic(2);

            painter.Start();
        }
    }
}
