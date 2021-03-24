using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DataForm
{
    public partial class Form1 : Form
    {
        private readonly Regex _name = new("(^[A-Z][a-zA-Z]*)$");        
        private readonly Regex _dob = new(@"^([0-2][0-9]|(3)[0-1])[.](((0)[0-9])|((1)[0-2]))[.]\d{4}$");
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
