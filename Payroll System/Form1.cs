using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class Form1 : Form
    {
        public List<Person> ListPerson = new List<Person>();
        public Form1()
        {
            InitializeComponent();


            //ListPerson = DataBase.PersonListFromDB();
            //listBox1.DataSource = ListPerson;
            listBox1.DataSource = DataBase.PersonListFromDB();
            listBox1.DisplayMember = "DisplaMembers";
            ClearTextBox();
            
        }


        #region Eventos y metodos


        private void btnHours_Click(object sender, EventArgs e)
        {
            //Actualiza la cantidad de horas de la persona
            Person person = (Person)listBox1.SelectedItem;
            person.HourWorked = float.Parse(TotalHoursTxt.Text);
            DataBase.UpdatePersonFromDb(person);
            UpdateData();
            

        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //Calcula How much does the person has to be paid
            var p = (Person)listBox1.SelectedItem;
            float total = p.WagePH * p.HourWorked;
            string msg = string.Format("Total To pay {0:C}", total);
            MessageBox.Show(msg);
            UpdateData();
        }
        private void btnPayThis_Click(object sender, EventArgs e)
        {
            //Paga a la persona Lo que ha ganado Segun sus horas
            var p = (Person)listBox1.SelectedItem;
            if (p.HourWorked > 0)
            {
                p.PaidAlready = true;
                p.HourWorked = 0.0f;
                DataBase.UpdatePersonFromDb(p);
                UpdateData();
            }
            else MessageBox.Show("No hours to pay");
            //Si la persona no tiene horas devuelve este mesaje

        }
        private void Clearallbtn_Click(object sender, EventArgs e)
        {
            //Boton que limpia los textos
            UpdateData();
            ClearTextBox();
            
        }
        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            //Agrega una persona a la lista
            Person p = new Person();
            p.Name = NameTxt.Text;
            p.LastName = LastNametTxt.Text;
            p.WagePH = float.Parse(PaymentHTxt.Text);
            DataBase.AddPersonToDB(p);
            ClearTextBox();
            UpdateData();
        }
        private void BtnRemoveEmplo_Click(object sender, EventArgs e)
        {
            var p = (Person)listBox1.SelectedItem;
            if (p != null)
            {
                DataBase.DeletePersonFromDB(p);
                UpdateData();
                ClearTextBox();
            }
        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0 && pictureBox1.Image == null)
            {
                OpenFileDialog open = new OpenFileDialog();


                open.Filter = "(*.Jpg;*.jpeg;*.bpm;) | *.Jpg;*.jpeg;*.bpm; ";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(open.FileName);
                    var p = (Person)listBox1.SelectedItem;
                    p.Image = ImageToByte(Image.FromFile(open.FileName));

                }




            }
        }
        #endregion



        #region         Helpermethods
        public void UpdateData()
        {
            //Refresca la connection
            //ListPerson = null;
            //ListPerson = DataBase.PersonListFromDB();
            listBox1.DataSource = null;
            listBox1.DataSource = DataBase.PersonListFromDB();
            //listBox1.DataSource = ListPerson;
            listBox1.DisplayMember = "DisplaMembers";
        }
        public void DataToTextboxes(Person p)
        {
            //Muesta los datos de las persona en los TxtBox

            //Se asegura de que un objeto sea devuelto
            if (p != null)
            {
                NameTxt.Text = p.Name;
                LastNametTxt.Text = p.LastName;
                AgeTxt.Text = p.ID.ToString();
                PaymentHTxt.Text = p.WagePH.ToString("C");
                TotalHoursTxt.Text = p.HourWorked.ToString();
                pictureBox1.Image = ByteArrayToImage(p.Image);
                if (p.PaidAlready)
                {
                    TotalHoursTxt.Text = "Paid Already";
                    TotalHoursTxt.ReadOnly = true;
                }
                else
                {
                    TotalHoursTxt.ReadOnly = false;
                }
            }


        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var p = (Person)listBox1.SelectedItem;
            //Devuelde un objeto cada que cambia el index en el listbox
            DataToTextboxes(p);



        }
        public void ClearTextBox()
        {

            //Limpia los TXTBOX y Limpia la seleccion del listbox
            AgeTxt.Clear();
            LastNametTxt.Clear();
            NameTxt.Clear();
            PaymentHTxt.Clear();
            TotalHoursTxt.Clear();
            listBox1.ClearSelected();
            pictureBox1.Image = null;
            TotalHoursTxt.ReadOnly = false;


        }
        /// <summary>
        /// Combierte una imagen en Byte[]
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        public static Image ByteArrayToImage(byte[] img)
        {
            using (MemoryStream mStream = new MemoryStream(img))
            {
                return Image.FromStream(mStream);
            }
        }
       
        #endregion

       
    }
}
