using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DataForm
{
    public partial class Form1 : Form
    {
        private readonly Regex _name = new("(^[A-Z][a-zA-Z]*)$");
        
        private readonly Regex _dob = 
            new("^(?:(?:31(\\/|-|\\.)(?:0?[13578]|1[02]))\\1|(?:(?:29|30)(\\/|-|\\.)(?:0?[13-9]|1[0-2])\\2))(?:(?:1[6-9]|[2-9]\\d)?\\d{2})$|^(?:29(\\/|-|\\.)0?2\\3(?:(?:(?:1[6-9]|[2-9]\\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\\d|2[0-8])(\\/|-|\\.)(?:(?:0?[1-9])|(?:1[0-2]))\\4(?:(?:1[6-9]|[2-9]\\d)?\\d{2})$");
        //StackOverFlow: https://stackoverflow.com/questions/15491894/regex-to-validate-date-format-dd-mm-yyyy
        
        private readonly Regex _email = new(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$");
        private readonly Regex _nrPhone = new(@"^[0-9]{9}$");

        private readonly string _statusOk = "Status: OK";
        private readonly string _statusIncorrect = "Status: Incorrect";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_FillUpClick(object sender, EventArgs e)
        {
            try
            {
                if (_name.IsMatch(_txtName.Text))
                {
                    _lblName.Text = _statusOk;
                    if (_dob.IsMatch(_txtDate.Text))
                    {
                        _lblDate.Text = _statusOk;
                        if (_email.IsMatch(_txtEmail.Text))
                        {
                            _lblEmail.Text = _statusOk;
                            if (_nrPhone.IsMatch(_txtPhone.Text))
                            {
                                _lblPhone.Text = _statusOk;
                                MessageBox.Show("You are good to go!", @"Info",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                _lblPhone.Text = _statusIncorrect;
                                MessageBox.Show("The Phone Nr is wrong!", @"Info",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            _lblEmail.Text = _statusIncorrect;
                            MessageBox.Show("The E-mail is wrong!", @"Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        _lblDate.Text = _statusIncorrect;
                        MessageBox.Show("The Date of birth is wrong!", @"Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    _lblName.Text = _statusIncorrect;
                    MessageBox.Show("The First name is wrong!", @"Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}