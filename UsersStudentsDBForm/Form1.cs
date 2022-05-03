using DataAccess.Data;
using DataAccess.Models;
using System.ComponentModel;
using System.Data.SqlClient;
using UsersStudentsDBForm.Components;
using UsersStudentsDBForm.Extensions;

namespace UsersStudentsDBForm
{
    public partial class Form1 : Form
    {
        public  UserData dataMethods { get; set; }
        private AutoCompleteStringCollection autoCompleteList { get; set; }
        private List<TextBox> textBoxes { get; set; }
        public string password { get; set; }
        //TODO PASSWORD WITH USER SECRETS

        public Form1()
        {   
            InitializeComponent();


            
            autoCompleteList = new AutoCompleteStringCollection();
            textBoxes = new List<TextBox>();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //TODO PASSWORD WITH USER SECRETS

            //DO REFACTORING
            Password passwordForm = new Password(this);
            passwordForm.Owner = this;
            passwordForm.ShowDialog();

            if (password == null)
            { this.Close(); return; }

            string connStr = ConfigHelper.GetConnectionString();
            connStr += ";Password=" + password;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connStr);
            dataMethods = new UserData(builder.ConnectionString);

            DataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            await DataView.UpdateDataViewAsync(dataMethods.GetAllUsers);

            stripMenuViewUpdate();

            //AUTOCOMPLETE
            foreach (Control control in SearchBox.Controls)
            {
                if (!(control.GetType() == typeof(TextBox))) continue;
                (control as TextBox).MouseDown += textBoxAutocompleteUpdate;
                textBoxes.Add(control as TextBox);
            }
        }


        //
        // CONTEXT MENU
        //
        private void contextMenuData_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DataView.DataSource is not IEnumerable<UserModel>)
            {
                e.Cancel = true;
            }
        }

        private async void contextMenuDeleteItem_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedRows.Count == 0) return;

            await dataMethods.DeleteUser(DataView.SelectedRows[0].Cells[0].Value.ToString());
            DataView.Rows.RemoveAt(DataView.SelectedRows[0].Index);
        }

        private void contextMenuUpdateItem_Click(object sender, EventArgs e)
        {
            radioButtonUpdate.Checked = true;
            //Get user id to update and save it
            DataGridViewRow selectedRow = DataView.SelectedRows[0];

            radioButtonUpdate.Tag = selectedRow.Cells[0].Value.ToString();
            radioButtonUpdate.Text += " пользователя с Id = " + selectedRow.Cells[0].Value.ToString();
            radioButtonUpdate.Enabled = true;

            //TODO: Do this with cycle
            textBoxFirstName.Text = selectedRow.Cells[1].Value?.ToString();
            textBoxLastName.Text = selectedRow.Cells[2].Value?.ToString();
            textBoxPatronymic.Text = selectedRow.Cells[3].Value?.ToString();
            textBoxEmail.Text = selectedRow.Cells[5].Value?.ToString();
            textBoxPhone.Text = selectedRow.Cells[6].Value?.ToString();
            textBoxTelegram.Text = selectedRow.Cells[7].Value?.ToString();
            textBoxUniversity.Text = selectedRow.Cells[8].Value?.ToString();
            textBoxCounty.Text = selectedRow.Cells[9].Value?.ToString();
            textBoxRegion.Text = selectedRow.Cells[10].Value?.ToString();
            textBoxTown.Text = selectedRow.Cells[11].Value?.ToString();
            textBoxStreet.Text = selectedRow.Cells[12].Value?.ToString();
            textBoxHouse.Text = selectedRow.Cells[13].Value?.ToString();
            textBoxFlat.Text = selectedRow.Cells[14].Value?.ToString();
            textBoxDescription.Text = selectedRow.Cells[15].Value?.ToString();
            textBoxDOB.Text = selectedRow.Cells[4].Value?.ToString();
        }


        //
        // TextBox AUTOCOMPLETE EVENTS
        //
        private async void textBoxAutocompleteUpdate(object sender, EventArgs e)
        {
            if (!radioButtonSearch.Checked) return;

            TextBox textBox = sender as TextBox;
            if (textBox.Tag == null) throw new NotImplementedException("Textbox Tag is null");

            string tag = textBox.Tag.ToString().Trim();
            await autoCompleteList.UpdateColumn(dataMethods, tag);
            textBox.AutoCompleteCustomSource = autoCompleteList;
        }


        //
        // MAIN BUTTONS 
        //
        private void buttonСlear_Click(object sender, EventArgs e)
        {
            textBoxesClearText();

            TextBoxValidators.errorProviderOff(textBoxes);
        }

        private async void buttonAction_Click(object sender, EventArgs e)
        {

            // VALIDATING
            if (!( ( radioButtonSearch.Checked || TextBoxValidators.validateFirstName(textBoxFirstName) )
                && TextBoxValidators.validateEmail(textBoxEmail)
                && TextBoxValidators.validatePhone(textBoxPhone)
                && TextBoxValidators.validateTelegram(textBoxTelegram)
                && TextBoxValidators.validateDOB(textBoxDOB)))
            {
                MessageBox.Show("Проверьте корректность введенных вами данных");
                return;
            }

            UserModel newUser = new UserModel
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Patronymic = textBoxPatronymic.Text,
                DOB = textBoxDOB.Text,
                Email = textBoxEmail.Text,
                Phone = textBoxPhone.Text,
                Telegram = textBoxTelegram.Text,
                University = textBoxUniversity.Text,
                Country = textBoxCounty.Text,
                Region = textBoxRegion.Text,
                Town = textBoxTown.Text,
                Street = textBoxStreet.Text,
                House = textBoxHouse.Text,
                Flat = textBoxFlat.Text,
                Description = textBoxDescription.Text
            };

            if (radioButtonSearch.Checked)
            {
                DataView.UpdateDataViewAsync<UserModel>(dataMethods.GetUsersBy, newUser);
            }
            else if (radioButtonInsert.Checked)
            {
                await dataMethods.InsertUser(newUser);
                DataView.UpdateDataViewAsync(dataMethods.GetAllUsers);
            }
            else if (radioButtonUpdate.Checked)
            {
                newUser.Id = int.Parse(radioButtonUpdate.Tag.ToString());
                await dataMethods.UpdateUser(newUser);
                DataView.UpdateDataViewAsync(dataMethods.GetAllUsers);
            }

        }


        //
        // RADIO BUTTONS CHECKED
        //
        private void radioButtonSearch_CheckedChanged(object sender, EventArgs e)
        {
            buttonAction.Text = "Поиск";

            radioButtonUpdate.Text = "Обновить данные...";
            radioButtonUpdate.Font = new Font(radioButtonUpdate.Font, FontStyle.Regular);
            radioButtonUpdate.Tag = null;
            radioButtonUpdate.Enabled = false;

            TextBoxValidators.errorProviderOff(textBoxes);
            textBoxesClearText();
            textBoxesEnableDisableTab(false);
        }

        private void radioButtonInsert_CheckedChanged(object sender, EventArgs e)
        {
            buttonAction.Text = "Добавить";

            radioButtonUpdate.Text = "Обновить данные...";
            radioButtonUpdate.Font = new Font(radioButtonUpdate.Font, FontStyle.Regular);
            radioButtonUpdate.Tag = null;
            radioButtonUpdate.Enabled = false;

            TextBoxValidators.errorProviderOff(textBoxes);
            textBoxesCleartAutoComplete();
            textBoxesEnableDisableTab(true);
        }

        private void radioButtonUpdate_CheckedChanged(object sender, EventArgs e)
        {
            buttonAction.Text = "Обновить";

            TextBoxValidators.errorProviderOff(textBoxes);
            textBoxesCleartAutoComplete();
            textBoxesEnableDisableTab(true);
        }


        //
        // VALIDATING
        //
        private void textBoxFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (!radioButtonInsert.Checked) return;
            TextBoxValidators.validateFirstName(textBoxFirstName);
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!radioButtonInsert.Checked) return;
            TextBoxValidators.validateEmail(textBoxEmail);
        }

        private void textBoxPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!radioButtonInsert.Checked) return;
            TextBoxValidators.validatePhone(textBoxPhone);
        }

        private void textBoxTelegram_Validating(object sender, CancelEventArgs e)
        {
            if (!radioButtonInsert.Checked) return;
            TextBoxValidators.validateTelegram(textBoxTelegram);
        }

        private void textBoxDOB_Validating(object sender, CancelEventArgs e)
        {
            if (!radioButtonInsert.Checked) return;
            TextBoxValidators.validateDOB(textBoxDOB);
        }

        //
        // Incapsulated
        //
        private void stripMenuViewUpdate()
        {
            таблицаToolStripMenuItem.DropDownItems.Clear();

            int i = 0;
            foreach (DataGridViewTextBoxColumn column in DataView.Columns)
            {
                var cb = new ToolStripCheckedBox()
                {
                    Text = column.Name.Replace("DataGridViewTextBoxColumn", ""),
                };

                cb.CheckBox.Tag = i;
                cb.CheckBox.Checked = true;
                cb.CheckBox.CheckedChanged += CheckBox_CheckedChanged;

                таблицаToolStripMenuItem.DropDownItems.Add(cb);
                i++;
            }
        }

        private void CheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            if (DataView.DataSource is IEnumerable<UserModel>)
            {
                CheckBox cb = (CheckBox)sender;
                DataView.Columns[(int)cb.Tag].Visible = cb.Checked;
            }
        }

        private void textBoxesEnableDisableTab(bool enable)
        {
            foreach (TextBox tb in textBoxes)
            {
                tb.TabStop = enable;
            }
        }

        private void textBoxesClearText()
        {
            foreach (TextBox tb in textBoxes)
            {
                tb.Text = "";
                TextBoxValidators.errorProviderOff(tb);
            }
        }

        private void textBoxesCleartAutoComplete()
        {
            foreach (TextBox tb in textBoxes)
            {
                tb.AutoCompleteCustomSource = null;
            }
        }
    }
}