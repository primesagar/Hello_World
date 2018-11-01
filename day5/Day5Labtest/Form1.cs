using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day5Labtest
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }



    List<string> userNamelist = new List<string>();
    List<string> firstNamelist = new List<string>();
    List<string> lastNamelist = new List<string>();
    List<string> contactNumberlist = new List<string>();
    List<string> emaillist = new List<string>();
    List<string> addresslist = new List<string>();
    List<string> accountNolist = new List<string>();

    
    private void saveButton_Click(object sender, EventArgs e)
    {
      string userName = userNameTextbox.Text;
      string firstNmae = firstNameTextBox.Text;
      string lastName = lastNameTextBox.Text;
      string contactNumber = contactNoTextBox.Text;
      string email = EmailTextBox.Text;
      string address = addressTextBox.Text;
      string accountNo = accountTextBox.Text;


      bool isUserNameUnique = UserNameUnique(userNamelist , userName);



    }

    public bool UserNameUnique()
    {
      
    }
    public void UserName(string userName)
    {

      userNamelist.Add(userName);
    }

    public void FirstName(string firstName)
    {
      firstNamelist.Add(firstName);
    }

    public void LastName(string lastName)
    {

      lastNamelist.Add(lastName);
    }

    public void ContactNo(string contactNumber)
    {
      contactNumberlist.Add(contactNumber);
    }

    public void Email(string email)
    {
      emaillist.Add(email);
    }

    public void Address(string address)
    {
      addresslist.Add(address);
    }

    public void Account(string accountNo)
    {
      accountNolist.Add(accountNo);
    }


  }
}
