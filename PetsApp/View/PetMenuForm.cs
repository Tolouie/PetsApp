using PetsApp.View;
using System;
using System.Windows.Forms;

namespace PetsApp
{
    public partial class Pets : Form
    {
        private int petID { get; set; } = 0;
        private int collectionID { get; set; } = 0;
        private string petType { get; set; } = String.Empty;
        private string petName { get; set; }
        private string food { get; set; }
        private string interaction { get; set; }
        PetEngine petEngine = new PetEngine();
        private static Timer aTimer;

        public Pets()
        {
            InitializeComponent();
        }


        //Assign pet type for adoption
        private void petsToAdoptLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            petType = petsToAdoptLstBox.SelectedItem.ToString();
            petIdentityLbl.Text = "Pet Identity: " + petType;
        }

        //Create pet object and add to instance of petDB
        private void adoptBtn_Click(object sender, EventArgs e)
        {
            var errorMsg = "";
            petName = petNameTxtBox.Text;
            try
            {
                if (petIdentityLbl.Text.ToLower() == "pet identity: ")
                {
                    errorMsg = "Please select a pet to adopt.";
                    throw new Exception();
                }
                if (String.IsNullOrWhiteSpace(petName))
                {
                    errorMsg = "Please make a name for your pet.";
                    throw new Exception();
                }

                petEngine.addPet(petID, petName, petType);
                PetModel tempPet = petEngine.getPet(petID);

                //Add items in the listview
                string[] arr = new string[4];
                ListViewItem itm;

                //Add first item
                arr[0] = petID.ToString();
                arr[1] = petName;
                arr[2] = petType;

                var currentTime = tempPet.Timer - (DateTime.Now - tempPet.StartingTime).TotalMilliseconds/1000 % tempPet.Timer;
                arr[3] = TimeSpan.FromMinutes((double)currentTime).ToString();

                itm = new ListViewItem(arr);
                myPetsCollectionLstView.Items.Add(itm);

                //Increment unique petID
                petID++;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(errorMsg, "Oops!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int getPetID()
        {
            try
            {
                if (myPetsCollectionLstView.SelectedItems.Count > 0)
                {
                    Int32.TryParse(myPetsCollectionLstView.SelectedItems[0].Text, out int result);
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("No pet selected", "Oops!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }
        private void viewBtn_Click(object sender, EventArgs e)
        {
            //TODO: Display state of pet
            resultLbl.Text = "Viewing";
            try
            {
                PetModel pet = petEngine.getPet(getPetID());
                if (pet != null)
                {
                    resultLstBox.Items.Clear();
                    resultLstBox.Items.Add(("Pet ID: " + pet.ID));
                    resultLstBox.Items.Add(("Name: " + pet.Name));
                    resultLstBox.Items.Add(("Type: " + pet.PetType));
                    resultLstBox.Items.Add(("Hunger: " + pet.Hunger + "/" + pet.MaxHunger));
                    resultLstBox.Items.Add(("Happiness: " + pet.Happiness + "/" + pet.MaxHappiness));
                    resultLstBox.Items.Add(("Healthy: " + pet.isHealthy()));

                    //calculate time elapsed for viewing
                    var elapsedTime = (DateTime.Now - pet.StartingTime).TotalMilliseconds / 1000;
                    var currentTime = pet.Timer - elapsedTime % pet.Timer;
                    resultLstBox.Items.Add(("Time: " + TimeSpan.FromMinutes((double)currentTime).ToString()));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void feedBtn_Click(object sender, EventArgs e)
        {
            try
            {
                collectionID = getPetID();
                if (collectionID >= 0)
                {
                    resultLstBox.Items.Clear();
                    resultLbl.Text = "Feeding";

                    //Attempt Feeding Here
                    var foodMenu = new FoodMenuView();
                    foodMenu.Show();
                    foodMenu.VisibleChanged += foodViewVisibleChanged;

                }
                else
                {
                    MessageBox.Show("No pet selected", "Oops!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void foodViewVisibleChanged(object sender, EventArgs e)
        {
            FoodMenuView frm = (FoodMenuView)sender;
            if (!frm.Visible)
            {
                this.food = frm.Food;
                petEngine.feedPet(collectionID, food);
                var pet = petEngine.getPet(collectionID);
                resultLstBox.Items.Add("Feeding " + food);
                resultLstBox.Items.Add(("Name: " + pet.Name));
                resultLstBox.Items.Add(("Hunger: " + pet.Hunger + "/" + pet.MaxHunger));
                resultLstBox.Items.Add(("Happiness: " + pet.Happiness + "/" + pet.MaxHappiness));
                resultLstBox.Items.Add(("Healthy: " + pet.isHealthy()));

                frm.Dispose();
            }
        }

        private void interactBtn_Click(object sender, EventArgs e)
        {
            //TODO: Update status of pet
            try
            {
                collectionID = getPetID();
                if (collectionID >= 0)
                {
                    resultLbl.Text = "Interacting";
                    resultLstBox.Items.Clear();

                    var interactionMenu = new InteractionMenuView();
                    interactionMenu.Show();
                    interactionMenu.VisibleChanged += interactionViewVisibleChanged;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void interactionViewVisibleChanged(object sender, EventArgs e)
        {
            InteractionMenuView frm = (InteractionMenuView)sender;
            if (!frm.Visible)
            {
                this.interaction = frm.Interaction;
                petEngine.interactPet(collectionID, interaction);
                var pet = petEngine.getPet(collectionID);
                if (pet.isHealthy())
                {
                    resultLstBox.Items.Add("Action: " + interaction);
                    resultLstBox.Items.Add(("Name: " + pet.Name));
                    resultLstBox.Items.Add(("Hunger: " + pet.Hunger + "/" + pet.MaxHunger));
                    resultLstBox.Items.Add(("Happiness: " + pet.Happiness + "/" + pet.MaxHappiness));
                    resultLstBox.Items.Add(("Healthy: " + pet.isHealthy()));
                }
                else
                {
                    MessageBox.Show(pet.Name + " is too hungry to interact", "Oops!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frm.Dispose();
            }
        }

        private void removePetBtn_Click(object sender, EventArgs e)
        {
            resultLbl.Text = "Removing";
            try
            {
                resultLstBox.Items.Clear();
                petEngine.removePet(getPetID());
                myPetsCollectionLstView.Items.Remove(myPetsCollectionLstView.SelectedItems[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void Timer_Tick(object sender, EventArgs e)
        {
            if (myPetsCollectionLstView.Items.Count > 0)
            {
                foreach (ListViewItem item in myPetsCollectionLstView.Items)
                {
                    Int32.TryParse(item.SubItems[0].Text, out int tempID);
                    var tempPet = petEngine.getPet(tempID);
                    var petTime = petEngine.getTime(tempPet);
                    item.SubItems[3].Text = petTime;
                }
            }
        }
        private void Pets_Load(object sender, EventArgs e)
        {
            // Create a timer and set a two second interval.
            aTimer = new Timer();
            aTimer.Interval = 1000;

            // Hook up the Elapsed evenBt for the timer. 
            aTimer.Tick += Timer_Tick;

            // Start the timer
            aTimer.Start();
        }
    }
}
