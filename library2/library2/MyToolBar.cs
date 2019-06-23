using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static library2.SettingsClass;

namespace library2
{
    public class MyToolBar : BindingNavigator
    {
        private ToolStripButton DataGrid_ToolstripAddNewItem = new ToolStripButton();
        private ToolStripButton DataGrid_ToolstripMoveNext = new ToolStripButton();
        private ToolStripButton DataGrid_ToolstripMoveBack = new ToolStripButton();
        private ToolStripSeparator bindingNavigatorSeparator1 = new ToolStripSeparator();
        private ToolStripSeparator bindingNavigatorSeparator2 = new ToolStripSeparator();
        private ToolStripSeparator bindingNavigatorSeparator3 = new ToolStripSeparator();
        private ToolStripButton toolStripButton1 = new ToolStripButton();
        private ToolStripButton toolStripButton2 = new ToolStripButton();
        private ToolStripButton findButton = new ToolStripButton();
        private ToolStripButton refreshButton = new ToolStripButton();
        private ToolStripLabel toolStripLabel = new System.Windows.Forms.ToolStripLabel();
        private ToolStripButton toolStripButtonBack = new ToolStripButton();
        private ToolStripButton toolStripButtonLast = new ToolStripButton();
        private ToolStripButton editButton = new ToolStripButton();
        private ToolStripButton deleteButton = new ToolStripButton();
        private ToolStripButton showIdsButton = new ToolStripButton();

        private ToolStripTextBox toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
        public SplitContainer splitContainer;
        public DataGridView dataGridView;
        public String table_name;
        public FormWithFieldsOptions option;
        private static SqlConnection sql_connection = SettingsClass.sql_connection;
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));

        public MyToolBar(FormWithFieldsOptions option)
        {
            this.option = option;
            InitializeMyToolBar();
            AddStandardItems();
        }
        public MyToolBar(String table_name, DataGridView dataGridView, SplitContainer splitContainer)
        {
            this.table_name = table_name;
            this.dataGridView = dataGridView;
            this.splitContainer = splitContainer;
            AddStandardItems();
            InitializeMyToolBar();
        }
        public override void AddStandardItems()
        {
            if (SettingsClass.rank != "Читатель")
            {
                this.Items.AddRange(new ToolStripItem[] {
                deleteButton,
                editButton,
                DataGrid_ToolstripAddNewItem,
                bindingNavigatorSeparator1
                });
            }
            this.Items.AddRange(new ToolStripItem[] {
                toolStripButtonBack,
                DataGrid_ToolstripMoveBack,
                toolStripLabel,
                toolStripTextBox1,
                DataGrid_ToolstripMoveNext,
                toolStripButtonLast,
                bindingNavigatorSeparator3,
                toolStripButton1,
                findButton,
                refreshButton,
                showIdsButton
            });
            if (option != FormWithFieldsOptions.Nothing) this.Items.Add(toolStripButton2);
        }
        private void InitializeMyToolBar()
        {
            // All cstom ToolStrip elements
            //
            this.editButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editButton.Image = global::library2.Properties.Resources.pencil;
            this.editButton.RightToLeftAutoMirrorImage = true;
            this.editButton.Size = new System.Drawing.Size(23, 22);
            this.editButton.Text = "Редактировать";
            this.editButton.Click += new EventHandler(editButton_Click);
            //
            // toolStripLabel1
            // 
            this.toolStripLabel.Name = "bindingNavigatorCountItem";
            this.toolStripLabel.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel.Text = "of {0}";
            this.toolStripLabel.ToolTipText = "Total number of items";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "bindingNavigatorPositionItem";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripButtonBack
            // 
            this.toolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBack.Image = global::library2.Properties.Resources.first;
            this.toolStripButtonBack.Name = "bindingNavigatorMoveFirstItem";
            this.toolStripButtonBack.RightToLeftAutoMirrorImage = true;
            this.toolStripButtonBack.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBack.Text = "Move first";
            // 
            // toolStripButtonLast
            // 
            this.toolStripButtonLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLast.Image = global::library2.Properties.Resources.last;
            this.toolStripButtonLast.RightToLeftAutoMirrorImage = true;
            this.toolStripButtonLast.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLast.Text = "Move last";

            deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            deleteButton.Image = global::library2.Properties.Resources.delete;
            deleteButton.Name = "deleteButton";
            deleteButton.RightToLeftAutoMirrorImage = true;
            deleteButton.Size = new System.Drawing.Size(23, 22);
            deleteButton.Text = "Удалить";
            deleteButton.Click += new EventHandler(deleteButton_Click);

            DataGrid_ToolstripAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            DataGrid_ToolstripAddNewItem.Image = global::library2.Properties.Resources.add;
            DataGrid_ToolstripAddNewItem.Name = "DataGrid_ToolstripAddNewItem";
            DataGrid_ToolstripAddNewItem.RightToLeftAutoMirrorImage = true;
            DataGrid_ToolstripAddNewItem.Size = new System.Drawing.Size(23, 22);
            DataGrid_ToolstripAddNewItem.Text = "Добавить";
            DataGrid_ToolstripAddNewItem.Click += new EventHandler(DataGrid_ToolstripAddNewItem_Click);

            DataGrid_ToolstripMoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            DataGrid_ToolstripMoveNext.Image = global::library2.Properties.Resources.next;
            DataGrid_ToolstripMoveNext.Name = "DataGrid_ToolstripMoveNext";
            DataGrid_ToolstripMoveNext.RightToLeftAutoMirrorImage = true;
            DataGrid_ToolstripMoveNext.Size = new System.Drawing.Size(23, 22);
            DataGrid_ToolstripMoveNext.Text = "Вперед";

            DataGrid_ToolstripMoveBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            DataGrid_ToolstripMoveBack.Image = global::library2.Properties.Resources.previous;
            DataGrid_ToolstripMoveBack.Name = "DataGrid_ToolstripMoveBack";
            DataGrid_ToolstripMoveBack.RightToLeftAutoMirrorImage = true;
            DataGrid_ToolstripMoveBack.Size = new System.Drawing.Size(23, 22);
            DataGrid_ToolstripMoveBack.Text = "Назад";

            toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = global::library2.Properties.Resources.filter;
            toolStripButton1.Name = "DataGrid_MyButton";
            toolStripButton1.Size = new System.Drawing.Size(43, 22);
            toolStripButton1.Text = "Фильтр";
            toolStripButton1.Click += new EventHandler(OnToolStripButton1_Click);
            toolStripButton1.BackColor = Color.Transparent;

            findButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            findButton.Image = global::library2.Properties.Resources.search;
            findButton.Name = "findButton";
            findButton.Size = new System.Drawing.Size(43, 22);
            findButton.Text = "Найти";
            findButton.Click += new EventHandler(findButton_Click);

            refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            refreshButton.Image = global::library2.Properties.Resources.refresh;
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new System.Drawing.Size(43, 22);
            refreshButton.Text = "Обновить";
            refreshButton.Click += new EventHandler(refreshButton_Click);

            showIdsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            showIdsButton.Image = global::library2.Properties.Resources.id;
            showIdsButton.Name = "showIdsButton";
            showIdsButton.Size = new System.Drawing.Size(43, 22);
            showIdsButton.Text = "Показать истинные значения";
            showIdsButton.Click += new EventHandler(showIdsButton_Click);
            toolStripButton1.BackColor = Color.Transparent;

            if (option != FormWithFieldsOptions.Nothing)
            {
                toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                toolStripButton2.Image = global::library2.Properties.Resources.choose;
                toolStripButton2.Name = "DataGrid_MyButton";
                toolStripButton2.Size = new System.Drawing.Size(43, 22);
                toolStripButton2.Text = "Выбрать";
                toolStripButton2.Click += new EventHandler(OnToolStripButton2_Click);
                toolStripButton2.BackColor = Color.Transparent;
            }

            CountItem = toolStripTextBox1;
            PositionItem = toolStripLabel;
            MoveFirstItem = toolStripButtonBack;
            MoveLastItem = toolStripButtonLast;
            MoveNextItem = DataGrid_ToolstripMoveNext;
            MovePreviousItem = DataGrid_ToolstripMoveBack;
        }


        //
        // Events
        //
        private void editButton_Click(object sender, EventArgs e)
        {
            FormWithFields formWithFields = new FormWithFields(table_name, dataGridView, FormWithFieldsOptions.edit);
            formWithFields.Show();
        }
        private void DataGrid_ToolstripAddNewItem_Click(object sender, EventArgs e)
        {
            FormWithFields formWithFields = new FormWithFields(table_name, dataGridView, FormWithFieldsOptions.add);
            formWithFields.Show();
        }
        private void OnToolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count != 0) dataGridView.SelectedCells[0].OwningRow.Selected = true;

            //int row_index = dataGridView.SelectedCells[0].RowIndex;
            String value = "";
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                try
                {
                    value += row.Cells["idDataGridViewTextBoxColumn"].Value.ToString() + ",";
                }
                catch (Exception ex)
                {
                    value += row.Cells["id"].Value.ToString() + ",";
                }

            }
            if (value != null) value = value.Substring(0, value.Length - 1);
            ((this.Parent.Parent as Form).Tag as Control).Text = value;
            (this.Parent.Parent as Form).Close();
        }
        private void OnToolStripButton1_Click(object sender, EventArgs e)
        {
            if (splitContainer.Panel1Collapsed)
            {
                splitContainer.Panel1Collapsed = false;
                (sender as ToolStripButton).BackColor = Color.LightGray;
            }
            else
            {
                splitContainer.Panel1Collapsed = true;
                (sender as ToolStripButton).BackColor = Color.Transparent;
            }
        }
        public void refreshButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand sql_command;
            SqlDataAdapter da;
            BindingSource bindingSource;



            sql_command = new SqlCommand("select * from " + table_name + ";", sql_connection);
            da = new SqlDataAdapter(sql_command);
            da.Fill(dt);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            this.dataGridView.DataSource = bindingSource;
            foreach (DataGridViewColumn clmn in dataGridView.Columns)
            {
                if (clmn.GetType().Name == "DataGridViewComboBoxColumn" && ((clmn as DataGridViewComboBoxColumn).DataSource as BindingSource).DataMember != "")
                {
                    try {
                        sql_command = new SqlCommand("select * from " + ((clmn as DataGridViewComboBoxColumn).DataSource as BindingSource).DataMember + ";", sql_connection);
                        da = new SqlDataAdapter(sql_command);
                        da.Fill(((clmn as DataGridViewComboBoxColumn).DataSource as BindingSource).DataSource as DataSet, ((clmn as DataGridViewComboBoxColumn).DataSource as BindingSource).DataMember);
                    }
                    catch(Exception ex) { }
                }
            }

            dataGridView.Invalidate();
            dataGridView.Refresh();
        }
        private void findButton_Click(object sender, EventArgs e)
        {
            FindingForm frm = new FindingForm(dataGridView);
            frm.Show();

        }
        private void showIdsButton_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripButton).BackColor == Color.Transparent)
            {
                foreach (DataGridViewColumn clmn in dataGridView.Columns)
                {
                    if (clmn.GetType().Name == "DataGridViewComboBoxColumn")
                    {
                        (clmn as DataGridViewComboBoxColumn).DisplayMember = (clmn as DataGridViewComboBoxColumn).ValueMember;
                    }
                }
                (sender as ToolStripButton).BackColor = Color.LightGray;
            }
            else
            {
                foreach (DataGridViewColumn clmn in dataGridView.Columns)
                {
                    if (clmn.GetType().Name == "DataGridViewComboBoxColumn")
                    {
                        try
                        {
                            (clmn as DataGridViewComboBoxColumn).DisplayMember = "name";
                        }
                        catch(Exception ex)
                        {
                            (clmn as DataGridViewComboBoxColumn).DisplayMember = "nameDataGridViewComboBoxColumn";
                        }
                    }
                }
                (sender as ToolStripButton).BackColor = Color.Transparent;
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                String query = null;
                if (dataGridView.SelectedRows.Count == 0) dataGridView.SelectedCells[0].OwningRow.Selected = true;
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    int id_value = -1;
                    try
                    {
                        id_value = Int32.Parse(row.Cells["id"].Value.ToString());
                    }
                    catch (Exception ex) { }
                    if (id_value == -1)
                    {
                        id_value = Int32.Parse(row.Cells["idDataGridViewTextBoxColumn"].Value.ToString());
                    }
                    query += "id = " + id_value + " or ";
                }
                query = query.Substring(0, query.Length - 3);
                DialogResult answer = MessageBox.Show($"Удалить {dataGridView.SelectedRows.Count} записей из таблицы {table_name} ?", "Удаление", MessageBoxButtons.OKCancel);
                if (answer == DialogResult.OK)
                {
                    try
                    {
                        SqlCommand sqlCommand = new SqlCommand($"Delete from {table_name} where {query}", sql_connection);
                        sql_connection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sql_connection.Close();
                        MessageBox.Show($"{dataGridView.SelectedRows.Count} записей удалено", "Удаление", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                    }
                }
                refreshButton_Click(null, null);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "В этой версии нельзя удалять запись без ID. Ждите обновлений", MessageBoxButtons.OK); }
        }
        //
        // Classes
        //
        public class FormWithFields : Form
        {
            private FlowLayoutPanel flowLayoutPanel;
            private DataGridView dataGridView;
            private bool requiredExists;
            public Button ok_btn; // Button "Добавить"
            public String table_name;
            public FormWithFieldsOptions option;
            public int id_value = -1;
            public int row_index = -1;

            public FormWithFields(String table_name, DataGridView dataGridView, FormWithFieldsOptions option)
            {
                this.option = option;
                this.table_name = table_name;
                this.dataGridView = dataGridView;
                SplitContainer splitContainer = new SplitContainer();
                splitContainer.Dock = DockStyle.Fill;
                splitContainer.FixedPanel = FixedPanel.Panel2;
                splitContainer.Orientation = Orientation.Horizontal;
                this.Controls.Add(splitContainer);
                this.Size = new Size(800, 500);
                flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Dock = DockStyle.Fill;
                flowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
                splitContainer.Panel1.Controls.Add(flowLayoutPanel);
                ok_btn = new Button();
                ok_btn.Size = new Size(100, 20);
                if (option == FormWithFieldsOptions.edit)
                {
                    ok_btn.Text = "Изменить";
                }
                else
                {
                    ok_btn.Text = "Добавить";
                }
                ok_btn.Enabled = false;
                ok_btn.Location = new Point(splitContainer.Width - ok_btn.Width - 20, 10);
                splitContainer.Panel2.Controls.Add(ok_btn);
                ok_btn.Click += new EventHandler(add_button_Click);
                if (option == FormWithFieldsOptions.add)
                    this.Text = "Добавить запись в таблицу " + table_name;
                if (option == FormWithFieldsOptions.edit)
                    this.Text = "Изменить запись в таблице " + table_name;
                Fill_FlowLayoutPanel();
            }
            private void Fill_FlowLayoutPanel() // Fills flowLayoutPanel with labels and controls for each column
            {
                if (dataGridView.SelectedCells.Count == 0) dataGridView.Rows[0].Selected = true;
                row_index = dataGridView.SelectedCells[0].OwningRow.Index;
                try
                {
                    id_value = Int32.Parse(dataGridView.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
                }
                catch (Exception ex) { }
                if (id_value == -1)
                {
                    if (option == FormWithFieldsOptions.edit)
                    id_value = Int32.Parse(dataGridView.SelectedCells[0].OwningRow.Cells["idDataGridViewTextBoxColumn"].Value.ToString());
                }
                library_dbDataSet ds = DataGridViews.library_db.library_dbDataSet;
                DataTable dt = ds.Tables[table_name];
                foreach (DataGridViewColumn clmn in dataGridView.Columns)
                {
                    String type = clmn.ValueType.Name;
                    String name = null;
                    Control control = null; // Will be either null, Form or DateTimePicker
                    String table_to_open = null;
                    String displayed_text = null;

                    if (option == FormWithFieldsOptions.edit)
                            displayed_text = dataGridView.Rows[row_index].Cells[clmn.Name].Value.ToString();
                    //if (option == FormWithFieldsOptions.add && clmn.HeaderText == "id")
                    //{
                    //    try
                    //    {
                    //        displayed_text = dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["id"].Value.ToString();
                    //    }
                    //    catch(Exception ex)
                    //    {
                    //        displayed_text = (Int32.Parse(dataGridView.Rows[dataGridView.Rows.Count - 2].Cells["idDataGridViewTextBoxColumn"].Value.ToString())+1).ToString();
                    //    }
                    //}
                        if (clmn.GetType().Name == "DataGridViewComboBoxColumn") // If column uses a view than button should open a form
                    {
                        name = (clmn as DataGridViewComboBoxColumn).ValueMember;
                        control = new Form();
                        (control as Form).TopLevel = false;
                    }
                    else
                    {
                        name = clmn.HeaderText;
                        if (type == "DateTime" || type == "Date") // If it's a date-type than button should open a form with datetimepicker
                        {
                            control = new DateTimePicker();
                        }
                        if (type == "Byte[]")
                        {
                            control = new PictureBox();
                        }

                    }
                    if (SettingsClass.tables_dict.ContainsKey(name))
                    {
                        control.Tag = SettingsClass.tables_dict[name];
                    }
                    //if (SettingsClass.controls_dict.ContainsKey(name))
                    //{
                    //    control.Tag = SettingsClass.controls_dict[name].Tag;
                    //}
                    bool required = !dt.Columns[clmn.Index].AllowDBNull; // Is current field necessary
                    if (required) requiredExists = true;
                    flowLayoutPanel.Controls.Add(new LabelAndControls(name, control, required, ok_btn, table_to_open, option, displayed_text));
                }
                if (foreign_dict.ContainsKey(table_name))
                {
                    foreach(String table in foreign_dict[table_name])
                    {
                        String name = null;
                        if (table.Contains("."))
                        {
                            name = table.Split(new char[] { '.' })[2] + " (множественный выбор)";
                        }
                        else
                        {
                            name = table + " (множественный выбор)";
                        }
                        Control control = null;
                        control = new Form();
                        (control as Form).TopLevel = false;
                        control.Tag = table;
                        flowLayoutPanel.Controls.Add(new LabelAndControls(name, control, false, ok_btn, null, FormWithFieldsOptions.chooseMultiple));
                    }
                }
                (flowLayoutPanel.Controls[1] as LabelAndControls).CheckFields();
                if (requiredExists)
                {
                    Label warning = new Label();
                    warning.Text = "Поля, отмеченные * обязательны для заполнения";
                    warning.Width = 500;
                    flowLayoutPanel.Controls.Add(warning);
                }
            }
            //
            // Events
            //
            private void add_button_Click(object sender, EventArgs e) // Generates and executes SQL string
            {
                SqlCommand sql_command = null;
                DataTable dt = new DataTable();

                String field_names = "";
                String field_values = "";
                String query = "";
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    LabelAndControls lc = (((this.Controls[0] as SplitContainer).Panel1.Controls[0] as FlowLayoutPanel).Controls[i] as LabelAndControls);

                    sql_command = new SqlCommand();
                    if (lc.value != null)
                    {

                        if (dataGridView.Columns[i].GetType().Name == "DataGridViewComboBoxColumn")
                        {
                            if (option == FormWithFieldsOptions.add)
                                field_names += (dataGridView.Columns[i] as DataGridViewComboBoxColumn).ValueMember + ",";
                            if (option == FormWithFieldsOptions.edit)
                                query += (dataGridView.Columns[i] as DataGridViewComboBoxColumn).ValueMember + " = ";
                        }
                        else
                        {
                            if (option == FormWithFieldsOptions.add)
                                field_names += dataGridView.Columns[i].HeaderText + ",";
                            if (option == FormWithFieldsOptions.edit)
                                query += dataGridView.Columns[i].HeaderText + " = ";
                        }
                        if (option == FormWithFieldsOptions.add)
                            if (lc.value.GetType().Name == "Byte[]")
                            {
                                field_values += "@IMG" + ",";
                                sql_command.Parameters.AddWithValue("@IMG", (lc.value as Byte[]));
                            }
                            else
                            {
                                field_values += lc.value.ToString() + ",";
                            }
                        if (option == FormWithFieldsOptions.edit)
                            if (lc.value.GetType().Name == "Byte[]")
                            {
                                query += "@IMG" + ",";
                                sql_command.Parameters.AddWithValue("@IMG", (lc.value as Byte[]));
                            }
                            else
                            {
                                query += lc.value.ToString() + ",";
                            }
                    }
                }
                int count = ((this.Controls[0] as SplitContainer).Panel1.Controls[0] as FlowLayoutPanel).Controls.Count;

                if (option == FormWithFieldsOptions.add)
                {
                    field_names = field_names.Remove(field_names.Length - 1);
                    field_values = field_values.Remove(field_values.Length - 1);
                }
                if (option == FormWithFieldsOptions.edit)
                    query = query.Remove(query.Length - 1);

                if (option == FormWithFieldsOptions.add)
                {
                    sql_command.CommandText = $"INSERT INTO {table_name} ({field_names}) VALUES ({field_values})";
                    sql_command.Connection = sql_connection;
                }
                if (option == FormWithFieldsOptions.edit)
                {
                    sql_command.CommandText = $"Update {table_name} set {query} where id = ({id_value})";
                    sql_command.Connection = sql_connection;
                }

                try
                {
                    sql_connection.Open();
                    sql_command.ExecuteNonQuery();
                    sql_connection.Close();

                    if (count > dataGridView.Columns.Count + 1)
                    {
                        //String mtm_table = manyToMany[table_name];
                        List<String> mtm_table = manyToMany[table_name];
                        if (option == FormWithFieldsOptions.edit)
                        {
                            foreach (String table in mtm_table)
                            {
                                sql_command.CommandText = $"delete from {table} where edition_id = {(((this.Controls[0] as SplitContainer).Panel1.Controls[0] as FlowLayoutPanel).Controls[0] as LabelAndControls).textBox.Text}";
                                sql_connection.Open();
                                sql_command.ExecuteNonQuery();
                                sql_connection.Close();
                            }
                        }

                        for (int i = 0; i<count- dataGridView.Columns.Count-1; i++)
                        {
                            if ((((this.Controls[0] as SplitContainer).Panel1.Controls[0] as FlowLayoutPanel).Controls[i + dataGridView.Columns.Count] as LabelAndControls).value != null)
                            {
                                String query2 = null;
                                String value = (((this.Controls[0] as SplitContainer).Panel1.Controls[0] as FlowLayoutPanel).Controls[i + dataGridView.Columns.Count] as LabelAndControls).value.ToString();
                                value = value.Substring(1, value.Length - 2);
                                String[] arr = value.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                                foreach (string s in arr)
                                {
                                    if (option == FormWithFieldsOptions.add)
                                        query2 += $"((select max(id) from {table_name}),{s}),";
                                    if (option == FormWithFieldsOptions.edit)
                                    {
                                        String id_value = (((this.Controls[0] as SplitContainer).Panel1.Controls[0] as FlowLayoutPanel).Controls[0] as LabelAndControls).textBox.Text;
                                        query2 += $"({id_value},{s}),";
                                    }
                                }
                                query2 = query2.Substring(0, query2.Length - 1);
                                sql_command.CommandText = $"INSERT INTO {mtm_table[i]} VALUES {query2}";
                                sql_connection.Open();
                                sql_command.ExecuteNonQuery();
                                sql_connection.Close();
                            }
                        }
                    }
                    if (option == FormWithFieldsOptions.add)
                        MessageBox.Show("Запись добавлена", "Ура", MessageBoxButtons.OK);
                    if (option == FormWithFieldsOptions.edit)
                        MessageBox.Show("Запись изменена", "Ура", MessageBoxButtons.OK);
                    ((dataGridView.Parent.Parent.Parent.Parent.Parent.Parent.Parent as TableLayoutPanel).Controls[0] as MyToolBar).refreshButton_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
                sql_connection.Close();
            }
            //
            // Classes
            //
            private class LabelAndControls : Control
            {
                private Label label;
                public Control control;
                public String label_text;
                public TextBox textBox;
                private bool required;
                public Button ok_btn;
                public object value = null;
                public String table_to_open;
                public String displayed_text = null;
                public FormWithFieldsOptions option;

                public LabelAndControls(String label_text, Control control, bool required, Button ok_btn, String table_to_open, FormWithFieldsOptions option, String displayed_text)
                {
                    this.table_to_open = table_to_open;
                    this.ok_btn = ok_btn;
                    this.required = required;
                    if (required)
                    {
                        this.label_text = label_text + "*";
                    }
                    else
                    {
                        this.label_text = label_text;
                    }
                    this.control = control;
                    this.option = option;
                    this.displayed_text = displayed_text;
                    InitializeComponents();
                }
                public LabelAndControls(String label_text, Control control, bool required, Button ok_btn, String table_to_open, FormWithFieldsOptions option)
                {
                    this.option = option;
                    this.table_to_open = table_to_open;
                    this.ok_btn = ok_btn;
                    this.required = required;
                    if (required)
                    {
                        this.label_text = label_text + "*";
                    }
                    else
                    {
                        this.label_text = label_text;
                    }
                    this.control = control;
                    InitializeComponents();
                }
            
                private void InitializeComponents()
                {
                    label = new Label();
                    if (required) this.label.Font = new Font(this.label.Font, FontStyle.Bold);
                    label.Text = label_text;
                    label.Width = 200;
                    textBox = new TextBox();
                    //if (option == FormWithFieldsOptions.add)
                    //{
                    //    if (label_text.Equals("id*"))
                    //    {
                    //        //textBox.Text = data
                    //        textBox.Enabled = false;
                    //    }
                    
                    if (label_text.Equals("id*"))
                    {
                        textBox.Text = "<default>";
                        textBox.Enabled = false;
                    }
                    this.Controls.Add(textBox);
                    textBox.TextChanged += new EventHandler(textBox_textChanged);
                    if (option == FormWithFieldsOptions.edit || (!label_text.Equals("id*") && option == FormWithFieldsOptions.add)) textBox.Text = displayed_text;
                    textBox.TextChanged += new EventHandler(activateAddButton);
                    textBox.Width = 200;
                    textBox.Location = new Point(0, label.Height);

                    if (control != null)
                    {
                        textBox.Width = 170;
                        Button btn = new Button();
                        btn.Text = "...";
                        btn.Location = new Point(175, label.Height);
                        btn.Width = 25;
                        btn.Tag = control.Tag;
                        this.Controls.Add(btn);
                        if (control.GetType().Name == "DateTimePicker")
                        {
                            // Now checks if DateTimePicker should include time picker
                            // if so - creates two DateTimePickers (it's set in the SettingsClass)
                            if ((control.Tag  as String) == "")
                            {
                                btn.Click += new EventHandler(pickDate_Click);
                            }
                            else
                            {
                                btn.Click += new EventHandler(pickDateTime_Click);
                            }
                        }
                        else
                        {
                            if (control.GetType().Name == "PictureBox")
                            {
                                btn.Click += new EventHandler(picture_btn_Click);
                            }
                            else
                            {
                                btn.Click += new EventHandler(btn_Click);
                            }
                        }
                    }

                    this.Controls.AddRange(new Control[] { label, control });
                    this.Size = new Size(200, 50);
                }
                //
                // Events
                //
                private void control_textChanged(object sender, EventArgs e)
                {
                    (sender as ComboBox).ForeColor = Color.Black;
                    if ((sender as ComboBox).SelectedIndex != -1)
                    {
                        //if ((sender as ComboBox).SelectedIndex == -1) (sender as ComboBox).Text = "";
                        if (string.IsNullOrEmpty((sender as ComboBox).SelectedValue.ToString()))
                        {
                            this.value = null;
                            return;
                        }
                        this.value = (sender as ComboBox).SelectedValue.ToString();
                    }
                    else
                    {
                        (sender as ComboBox).ForeColor = Color.Transparent;
                    }
                }
                private void textBox_textChanged(object sender, EventArgs e)
                {
                    if (string.IsNullOrEmpty((sender as TextBox).Text))
                    {
                        this.value = "NULL";
                        return;
                    }
                    if (this.label_text != "id*" && this.label_text != "id" && textBox.Text != "System.Byte[]") this.value = "'" + (sender as TextBox).Text + "'";
                }
                private void picture_btn_Click(object sender, EventArgs e)
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = ("JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*");
                    dialog.Title = "Выберите фото";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        String pic = dialog.FileName.ToString();
                        this.textBox.Text = pic;
                        byte[] imageBt = null;
                        FileStream fs = new FileStream(pic, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        imageBt = br.ReadBytes((int)fs.Length);
                        value = imageBt;
                    }
                }
                private void activateAddButton(object sender, EventArgs e)
                {
                    if (label.Text != "id*" && label.Text != "id")
                    {
                        CheckFields();
                    }
                }
                public void CheckFields() // Checks if every required field is filled
                {
                    ControlCollection controls = (this.Parent as FlowLayoutPanel).Controls;
                    bool lockAddButton = false;
                    for (int i = 1; i < controls.Count - 1; i++)
                    {
                        if ((controls[i] as LabelAndControls).required && (controls[i] as LabelAndControls).value == null)
                        {
                            lockAddButton = true;
                            //break;
                        }
                    }
                    if (!lockAddButton) ok_btn.Enabled = true;
                    else ok_btn.Enabled = false;
                }
                private void pickDateTime_Click(object sender, EventArgs e)
                {
                    Form frm = new Form();
                    frm.Size = new Size(310, 60);
                    frm.Text = "Выбрать дату";
                    frm.Show();
                    DateTimePicker date_picker = new DateTimePicker();
                    DateTimePicker time_picker = new DateTimePicker();
                    date_picker.Size = new Size(200, 30);
                    time_picker.Size = new Size(90, 30);
                    time_picker.Location = new Point(205, 0);
                    time_picker.Format = DateTimePickerFormat.Time;
                    time_picker.ShowUpDown = true;
                    date_picker.Tag = ((sender as Button).Parent as LabelAndControls).textBox;
                    time_picker.Tag = ((sender as Button).Parent as LabelAndControls).textBox;
                    frm.Controls.Add(date_picker);
                    frm.Controls.Add(time_picker);

                    date_picker.ValueChanged += new EventHandler(picker_ValueChanged);
                    time_picker.ValueChanged += new EventHandler(picker_ValueChanged);
                }
                private void picker_ValueChanged(object sender, EventArgs e)
                {
                    String date = (sender as DateTimePicker).Value.ToString("MM/dd/yyyy");
                    String time = (sender as DateTimePicker).Value.ToString("hh:mm:ss");
                    ((sender as DateTimePicker).Tag as TextBox).Text = date + ' ' + time;
                }
                private void pickDate_Click(object sender, EventArgs e)
                {
                    Form frm = new Form();
                    frm.Size = new Size(210,60);
                    frm.Text = "Выбрать дату";
                    frm.Show();
                    DateTimePicker date_picker = new DateTimePicker();
                    date_picker.Tag = ((sender as Button).Parent as LabelAndControls).textBox;
                    date_picker.Size = new Size(200, 30);
                    frm.Controls.Add(date_picker);

                    date_picker.ValueChanged += new EventHandler(picker2_ValueChanged);
                }
                private void picker2_ValueChanged(object sender, EventArgs e)
                {
                    String date = (sender as DateTimePicker).Value.ToString("yyyy/dd/MM");
                    ((sender as DateTimePicker).Tag as TextBox).Text = date;
                }
                private void btn_Click(object sender, EventArgs e) // Creates new form and fills it with Kit class
                {
                    Form frm = new Form();
                    
                    frm.Size = new Size(500, 300);
                    Form1.Kit kit;
                    String value = ((sender as Control).Tag as String); // Getting value from tables_dict from SettingsClass
                    if (!value.Contains("DataGridViews"))
                    {
                        kit = new Form1.Kit(frm, value, option);
                    }
                    else
                    {
                        DataGridView dgv = (DataGridView)Activator.CreateInstance(Type.GetType(value));
                        kit = new Form1.Kit(frm, dgv, option);
                    }
                    frm.Tag = this.textBox;
                    frm.Show();
                }
            }
        }
        public class FindingForm : Form
        {
            private DataGridView dataGridView;
            private TextBox tb = new TextBox();
            private ComboBox cb = new ComboBox();
            private Label found_info = new Label();

            public FindingForm(DataGridView dataGridView)
            {
                found_info.Size = new Size(200, 20);
                found_info.Location = new Point(200, 0);
                this.Controls.Add(found_info);
                this.Size = new Size(350, 100);
                this.dataGridView = dataGridView;
                Button find_btn = new Button();
                find_btn.Text = "Искать";
                find_btn.Size = new Size(100, 20);
                find_btn.Location = new Point(250, this.Height / 2 - find_btn.Height / 2);
                this.Controls.Add(find_btn);
                find_btn.Click += new EventHandler(find_btn_Click);
                tb.Size = new Size(200, 20);
                tb.Location = new Point(0, this.Height / 2 - find_btn.Height / 2);
                this.Controls.Add(tb);
                cb.Size = new Size(200, 20);
                cb.Location = new Point(0, 0);
                this.Controls.Add(cb);
                List<ComboboxItem> list = new List<ComboboxItem>();
                foreach (DataGridViewColumn clmn in dataGridView.Columns)
                {
                    list.Add(new ComboboxItem(clmn.HeaderText, clmn.ValueType.Name));
                }
                list.Add(new ComboboxItem("(Искать по всем полям)", null));
                cb.DataSource = list;
                cb.SelectedIndex = list.Count - 1;
            }

            private List<int> Find(DataGridView dataGridView, int field, String text, bool findAll) // Search for records containing 'text' and puts in container
            {
                List<int> collection = new List<int>();
                String value = null;
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    if (findAll)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            value = dataGridView.Rows[i].Cells[j].FormattedValue.ToString();
                            if (value.ToLower().Contains(text.ToLower()))
                            {
                                collection.Add(dataGridView.Rows[i].Index);
                                break;
                            }
                        }
                    }
                    else
                    {
                        value = dataGridView.Rows[i].Cells[field].FormattedValue.ToString();
                        if (value.ToLower().Contains(text.ToLower())) collection.Add(dataGridView.Rows[i].Index);
                    }

                }
                return collection;
            }
            //
            // Events
            //
            private void find_btn_Click(object sender, EventArgs e)
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    row.Selected = false;
                }
                String field = (cb.SelectedItem as ComboboxItem).Text;
                String type = null;
                try
                {
                    type = (cb.SelectedItem as ComboboxItem).Value.ToString();
                }
                catch (Exception ex)
                {

                }
                List<int> collection;
                if (type == null)
                {
                    collection = Find(dataGridView, cb.SelectedIndex, tb.Text, true);
                }
                else
                {
                    collection = Find(dataGridView, cb.SelectedIndex, tb.Text, false);
                }
                found_info.Text = $"Найдено {collection.Count} записей";
                foreach (int i in collection)
                {
                    dataGridView.Rows[i].Selected = true;
                }
            }
            //
            // Classes
            //

        }
    }
}
