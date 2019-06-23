using library2.DataGridViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Form1 : Form
    {
        public String rank = "Читатель";
        private Kit kit1 = null;
        public class Kit
        {
            private Control control; // Address of control object where all custom controls are added
            public DataGridView dataGridView = new DataGridView(); // Main table with data from database
            private ComboDataGridView searchTable; // Instance of a class inherited from DataGridView
            private String table_name; // Name of a table from which data will be retrieved for dataGridView
            private MyToolBar myToolBar; // Instance of a class inherited from BindingNavigator
            private TabControl tabControl = new TabControl(); // TabControl for stored procedures
            private SqlCommand[] sqlCommands = null;
            private List<String> tabs = null;
            private static SqlConnection sql_connection = SettingsClass.sql_connection;
            private PictureBox pb = new PictureBox();
            private int index = -1;
            private bool hasPhoto = false;
            private FormWithFieldsOptions option;
            private SplitContainer splitContainer3;
            public ToolStrip ts = new ToolStrip();

            public Kit(Control control, String table_name, FormWithFieldsOptions option)
            {
                this.option = option;
                this.control = control;
                this.table_name = table_name;

                InitializeComponents();
            }
            public Kit(Control control, DataGridView dataGridView, FormWithFieldsOptions option)
            {
                this.option = option;
                this.control = control;
                this.dataGridView = dataGridView;
                this.table_name = (dataGridView.DataSource as BindingSource).DataMember;

                InitializeComponents();
            }
            public Kit(Control control, String table_name)
            {
                this.control = control;
                this.table_name = table_name;

                InitializeComponents();
            }
            public Kit(Control control, DataGridView dataGridView)
            {
                this.control = control;
                this.table_name = (dataGridView.DataSource as BindingSource).DataMember;
                this.dataGridView = dataGridView;

                InitializeComponents();
            }
            public Kit(Control control, DataGridView dataGridView, List<String> tabs, SqlCommand[] sqlCommands)
            {
                this.control = control;
                this.dataGridView = dataGridView;
                this.sqlCommands = sqlCommands;
                this.tabs = tabs;
                this.table_name = (dataGridView.DataSource as BindingSource).DataMember;

                InitializeComponents();
            }
            public Kit(Control control, String table_name, List<String> tabs, SqlCommand[] sqlCommands)
            {
                this.control = control;
                this.table_name = table_name;
                this.tabs = tabs;
                this.sqlCommands = sqlCommands;
                //this.dataGridView = new DataGridView();

                InitializeComponents();
            }

            private void CreateTabs() // Creates tabs for stored procedures
            {
                tabControl = new TabControl();
                tabControl.SelectedIndexChanged += new EventHandler(tabControl_SelectedIndexChanged);
                tabControl.Dock = DockStyle.Fill;
                foreach (String s in tabs)
                {
                    TabPage tb = new TabPage();
                    DataGridView dgv = new DataGridView();
                    dgv.BackgroundColor = Color.Lavender;
                    dgv.Dock = DockStyle.Fill;
                    dgv.RowTemplate.Height = 15;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    tb.Controls.Add(dgv);
                    tb.Text = s;
                    tabControl.Controls.Add(tb);
                }
                DataGridView dataGridView1 = new DataGridView();
                dataGridView1.Dock = DockStyle.Fill;
            }
            private void InitializeComponents()
            {
                //dataGridView.DataSourceChanged += sourceChanged;
                FillDataGridView();
                myToolBar = new MyToolBar(option);

                if (tabs != null) CreateTabs();
                dataGridView.Location = new System.Drawing.Point(0, 0);
                dataGridView.Dock = DockStyle.Fill;
                dataGridView.TabIndex = 1;
                dataGridView.SelectionChanged += new EventHandler(dataGridView_SelectionChanged);
                dataGridView.CellDoubleClick += cell_Click;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView.RowTemplate.Height = 15;
                dataGridView.BackgroundColor = Color.Honeydew;
                dataGridView.DataBindingComplete += DataSourceChanged;
                dataGridView.DataError += (s, e) => { };
                if (option == FormWithFieldsOptions.chooseMultiple || option == FormWithFieldsOptions.Nothing) dataGridView.MultiSelect = true;
                else dataGridView.MultiSelect = false;

                searchTable = new ComboDataGridView(dataGridView, myToolBar, table_name);
                searchTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                searchTable.Location = new Point(0, 0);
                searchTable.Dock = DockStyle.Fill;

                SplitContainer splitContainer2 = new SplitContainer();
                splitContainer2.Orientation = Orientation.Horizontal;
                splitContainer2.Dock = DockStyle.Fill;
                splitContainer2.SplitterWidth = 3;
                splitContainer2.BorderStyle = BorderStyle.Fixed3D;
                splitContainer2.Panel1.Controls.AddRange(new Control[] { searchTable });
                splitContainer2.Panel2.Controls.AddRange(new Control[] { dataGridView });
                splitContainer2.Panel1Collapsed = true;
                ts.Dock = DockStyle.Bottom;
                splitContainer2.Panel2.Controls.Add(ts);

                Label label = new Label();
                //label.Dock = DockStyle.Fill;
                label.Text = (dataGridView.Tag as String);
                splitContainer3 = new SplitContainer();
                splitContainer3.Orientation = Orientation.Vertical;
                splitContainer3.Dock = DockStyle.Fill;
                splitContainer3.SplitterWidth = 3;
                splitContainer3.BorderStyle = BorderStyle.Fixed3D;
                splitContainer3.Panel1.Controls.AddRange(new Control[] { splitContainer2 });
                //splitContainer3.Panel2.Controls.AddRange(new Control[] { label });
                splitContainer3.SplitterDistance = 750;
                splitContainer3.Panel2.BackColor = Color.Beige;
                pb.Dock = DockStyle.Fill;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                splitContainer3.Panel2Collapsed = !hasPhoto;
                //splitContainer3.Panel2Collapsed = true;
                if (hasPhoto) splitContainer3.Panel2.Controls.Add(pb);

                SplitContainer splitContainer1 = new SplitContainer();
                splitContainer1.Dock = DockStyle.Fill;
                splitContainer1.Orientation = Orientation.Horizontal;
                splitContainer1.SplitterWidth = 3;
                splitContainer1.BorderStyle = BorderStyle.None;
                splitContainer1.Panel1.Controls.AddRange(new Control[] { splitContainer3 });
                splitContainer1.Panel2.Controls.Add(tabControl);


                myToolBar.option = option;
                myToolBar.table_name = table_name;
                myToolBar.dataGridView = dataGridView;
                myToolBar.splitContainer = splitContainer2;
                
                myToolBar.Location = new Point(0, 0);
                myToolBar.BindingSource = (dataGridView.DataSource as BindingSource);
                
                if (sqlCommands == null || sqlCommands.Length == 0) splitContainer1.Panel2Collapsed = true;
                StatusStrip statusStrip = new StatusStrip();
                statusStrip.Items.Add($"Книг всего: {quickData[0]} | В библиотеке: {quickData[1]} | На руках: {quickData[2]} | Читатели: {quickData[3]}");
                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.Dock = DockStyle.Fill;
                tableLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

                tableLayoutPanel.Controls.Add(myToolBar);
                tableLayoutPanel.Controls.Add(splitContainer1);
                //tableLayoutPanel.Controls.Add(statusStrip);
                control.Controls.Add(tableLayoutPanel);
                control.Controls.Add(statusStrip);
                dataGridView.Refresh();
                if (dataGridView is IHaveMoreInfo)
                {
                    WebBrowser lbl = new WebBrowser();
                    lbl.Dock = DockStyle.Fill;
                    splitContainer3.Panel2.Controls.Add(lbl);
                    splitContainer3.Panel2Collapsed = false;
                }
                try
                {
                    String info = (dataGridView as DataGridViews.IHaveinfo).GetInfo();
                    Label lbl = new Label();
                    lbl.Text = info;
                    lbl.Dock = DockStyle.Fill;
                    //lbl.Width = 200;
                    splitContainer3.Panel2.Controls.Add(lbl);
                    //lbl.MaximumSize = new Size(lbl.Parent.Width - 10, 100);
                    //lbl.AutoSize = true;
                    lbl.Refresh();
                    splitContainer3.Panel2Collapsed = false;
                }
                catch (Exception ex)
                {

                }

            }

            private void sourceChanged(object sender, EventArgs e)
            {

                int rows = ((dataGridView.DataSource as BindingSource).DataSource as DataTable).Rows.Count;
                ts.Items.Add("Всего " + rows.ToString());
            }

            private void DataSourceChanged(object sender, EventArgs e)
            {
                try
                {
                    (dataGridView as DataGridViews.ISelectable).SelectRows(dataGridView);
                }
                catch (Exception ex) { }
            }

            public void FillDataGridView()
            {
                DataTable dt = new DataTable();

                SqlCommand sql_command = new SqlCommand("select * from " + table_name + ";", sql_connection);
                SqlDataAdapter da = new SqlDataAdapter(sql_command);
                da.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;
                this.dataGridView.DataSource = bindingSource;

                
                foreach (DataGridViewColumn clmn in dataGridView.Columns) // Color the ComboBox columns
                {
                    if (clmn.Name == "photoDataGridViewImageColumn")
                    {
                        hasPhoto = true;
                        index = clmn.Index;
                    }
                    if (clmn.GetType().Name == "DataGridViewComboBoxColumn")
                    {
                        (clmn as DataGridViewComboBoxColumn).DefaultCellStyle.BackColor = Color.Khaki;
                    }
                }

            }
            //
            // Events
            //
            private void cell_Click(object sender, EventArgs e)
            {
                if ((sender as DataGridView).CurrentCell.OwningColumn.GetType().Name == "DataGridViewComboBoxColumn")
                {
                    DataGridViewComboBoxColumn clmn = ((sender as DataGridView).CurrentCell.OwningColumn as DataGridViewComboBoxColumn);

                    if (SettingsClass.tables_dict.ContainsKey(clmn.ValueMember))
                    {
                        Form frm = new Form();
                        frm.Size = SettingsClass.tableWindowSize;
                        Kit kit = null;
                        if (SettingsClass.tables_dict[clmn.ValueMember].Contains("DataGridViews"))
                        {
                            kit = new Kit(frm, Activator.CreateInstance(Type.GetType(SettingsClass.tables_dict[clmn.ValueMember])) as DataGridView);
                        }
                        else
                        {
                            kit = new Kit(frm, SettingsClass.tables_dict[clmn.ValueMember]);
                        }
                        frm.Show();
                        String row_index = null;
                        row_index = (dataGridView.SelectedCells[0] as DataGridViewComboBoxCell).Value.ToString();
                        try
                        {
                            int index = (kit.dataGridView.DataSource as BindingSource).Find("id", row_index);
                            kit.dataGridView.Rows[index].Selected = true;
                        }
                        catch (Exception ex) { }
                    }
                }
            }
            private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
            {
                dataGridView_SelectionChanged(sender, e);
            }
            private void dataGridView_SelectionChanged(object sender, EventArgs e) // Fills dataGridViews with stored procedures
            {
                try
                {
                    int current_id = -1;
                    try
                    {
                        current_id = (int)dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells["id"].Value;
                    }
                    catch (Exception ex)
                    {
                        current_id = (int)dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value;
                    }
                    ((dataGridView.Parent as SplitterPanel).Controls[1] as ToolStrip).Items.Clear();
                    int rows = ((dataGridView.DataSource as BindingSource).DataSource as DataTable).Rows.Count;
                    ts.Items.Add("Всего "+rows.ToString());
                    ((dataGridView.Parent as SplitterPanel).Controls[1] as ToolStrip).Items.Add((dataGridView as IHavetrivia).getTrivia(current_id));
                }
                catch(Exception ex)
                {

                }
                try
                {
                    int current_id = -1;
                    try
                    {
                        current_id = (int)dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells["id"].Value;
                    }
                    catch (Exception ex)
                    {
                        current_id = (int)dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value;
                    }
                    //Label lbl = new Label();
                    //lbl.Text = ((dataGridView as IHaveMoreInfo).getInfo(current_id));
                    //lbl.Dock = DockStyle.Fill;
                    (splitContainer3.Panel2.Controls[0] as WebBrowser).DocumentText = ((dataGridView as IHaveMoreInfo).getInfo(current_id));
                    //lbl.Refresh();
                    //splitContainer3.Panel2Collapsed = false;
                }
                catch (Exception ex)
                {
                    sql_connection.Close();
                   // MessageBox.Show(ex.Message);
                }
                //dataGridView.Refresh();
                //if (dataGridView.SelectedRows.Count != 0) dataGridView.CurrentCell = dataGridView.SelectedRows[0].Cells[0];
                if (hasPhoto && dataGridView.CurrentCell != null)
                {
                    byte[] imageBt = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[index].Value.ToString() == "" ? null : (byte[])dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[index].Value;
                    if (imageBt != null)
                    {
                        MemoryStream ms = new MemoryStream(imageBt);
                        pb.Image = Image.FromStream(ms);
                        pb.Refresh();
                    }
                    else
                    {
                        pb.Image = null;
                        pb.Refresh();
                    }
                }

                int pageIndex = tabControl.SelectedIndex > -1 ? tabControl.SelectedIndex : 0;
                try
                {

                    SqlCommand sql_command = new SqlCommand();
                    DataTable dt = new DataTable();
                    sql_command.CommandType = sqlCommands[pageIndex].CommandType;
                    sql_command.CommandText = sqlCommands[pageIndex].CommandText;
                    sql_command.Connection = sql_connection;

                    if (sql_command.CommandType == CommandType.StoredProcedure)
                    {
                        int id = int.Parse(dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
                        sql_command.Parameters.Add("@var1", SqlDbType.Int);
                        sql_command.Parameters["@var1"].Value = id;
                    }

                    SqlDataAdapter da = new SqlDataAdapter(sql_command);
                    da.Fill(dt);
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;

                    (tabControl.TabPages[pageIndex].Controls[0] as DataGridView).DataSource = bs;
            }
            catch (Exception ex) { }
    }            
        }

        public Form1(String rank)
        {
            this.rank = rank;
            InitializeComponent();
            this.Text += " - Вы вошли как " + rank;
            //Form3 frm = new Form3();
            //frm.Show();
            tabControl1.SelectedTab = tabPage2;

            SqlCommand sql_command1, sql_command2, sql_command3, sql_command4, sql_command5;
            sql_command1 = new SqlCommand("[sp_getBookChronology]");
            sql_command1.CommandType = CommandType.StoredProcedure;
            sql_command2 = new SqlCommand("[sp_getLendBookChronology]");
            sql_command2.CommandType = CommandType.StoredProcedure;
            sql_command3 = new SqlCommand("[sp_getRetBookChronology]");
            sql_command3.CommandType = CommandType.StoredProcedure;
            sql_command4 = new SqlCommand("[sp_getAuthors]");
            sql_command4.CommandType = CommandType.StoredProcedure;
            sql_command5 = new SqlCommand("[sp_get_keywords]");
            sql_command5.CommandType = CommandType.StoredProcedure;

            kit1 = new Kit(tabPage1, new DataGridViews.Editions(), new List<string>() { "Хронология", "Выдача", "Возврат", "Авторы", "Ключевые слова" }, new SqlCommand[] { sql_command1, sql_command2, sql_command3, sql_command4, sql_command5 });

            sql_command1 = new SqlCommand("[sp_getChronology]");
            sql_command1.CommandType = CommandType.StoredProcedure;
            sql_command2 = new SqlCommand("[sp_getLendChronology]");
            sql_command2.CommandType = CommandType.StoredProcedure;
            sql_command3 = new SqlCommand("[sp_getRetChronology]");
            sql_command3.CommandType = CommandType.StoredProcedure;
            sql_command4 = new SqlCommand("[sp_getLentBooks]");
            sql_command4.CommandType = CommandType.StoredProcedure;
            sql_command5 = new SqlCommand("[sp_get_studyGroops]");
            sql_command5.CommandType = CommandType.StoredProcedure;

            Kit kit2 = new Kit(tabPage2, new DataGridViews.Readers(), new List<string>() { "Хронология", "Выдача", "Возврат", "Книги на руках", "Группы читателя" }, new SqlCommand[] { sql_command1, sql_command2, sql_command3, sql_command4, sql_command5 });

            sql_command1 = new SqlCommand("[sp_get_bookList]");
            sql_command1.CommandType = CommandType.StoredProcedure;

            Kit kit3 = new Kit(tabPage3, new DataGridViews.Authors(), new List<string>() { "Издания автора" }, new SqlCommand[] { sql_command1 });

            sql_command1 = new SqlCommand("[sp_get_bookListForPublishers]");
            sql_command1.CommandType = CommandType.StoredProcedure;

            Kit kit4 = new Kit(tabPage4, new DataGridViews.Publishers(), new List<string>() { "Издания выданные издательством" }, new SqlCommand[] { sql_command1 });
            Kit kit5 = new Kit(tabPage5, new DataGridViews.Debentures(), new List<string>(), new SqlCommand[] { });

        }

        private void изданияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Readers frm = new Form_Readers();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form_Readers frm = new Form_Readers();
            frm.Show();
        }

        private void читателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Readers frm = new Form_Readers();
            frm.Show();
        }

        private void улицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView_Streets = new DataGridViews.Streets();
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, dataGridView_Streets);
            frm.Show();
        }

        private void типыУлицToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, "StreetTypes");
            frm.Show();
        }

        private void типыНаселенныхПунктовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, "LocalityTypes");
            frm.Show();
        }

        private void адресаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView_Addresses = new DataGridViews.Addresses();
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, dataGridView_Addresses);
            frm.Show();
        }

        private void населенныеПунктыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView_Localities = new DataGridViews.Localities();
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, dataGridView_Localities);
            frm.Show();
        }

        private void страныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, "Contries");
            frm.Show();
        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView_Editions = new DataGridViews.Editions();
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, dataGridView_Editions);
            frm.Show();
        }

        private void экземплярыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView_Copies = new DataGridViews.Copies();
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, dataGridView_Copies);
            frm.Show();
        }

        private void читателиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DataGridView dataGridView_Readers = new DataGridViews.Readers();
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, dataGridView_Readers);
            frm.Show();
        }

        private void задолженностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView_Debentures = new DataGridViews.Debentures();
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, dataGridView_Debentures);
            frm.Show();
        }

        private void хронологияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView_Chronology = new DataGridViews.Chronology();
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, dataGridView_Chronology);
            frm.Show();
        }

        private void полыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, "Genders");
            frm.Show();
        }

        private void типыОперацийToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, "Operations");
            frm.Show();
        }

        private void типыИзданийToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, "EditionTypes");
            frm.Show();
        }

        private void языкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, "Languages");
            frm.Show();
        }

        private void жанрыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, "Genres");
            frm.Show();
        }

        private void предметыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, "Subjects");
            frm.Show();
        }

        private void работникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView_Staff = new DataGridViews.Staff();
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, dataGridView_Staff);
            frm.Show();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, "Positions");
            frm.Show();
        }

        private void авторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView_Authors = new DataGridViews.Authors();
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, dataGridView_Authors);
            frm.Show();
        }

        private void издательстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView_Publishers = new DataGridViews.Publishers();
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, dataGridView_Publishers);
            frm.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void книгиКлючевыеСловаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView_EditionsKeywords = new DataGridViews.EditionsKeywords();
            Form frm = new TableForm("Таблица " + (sender as ToolStripMenuItem).Text);
            Kit kit = new Kit(frm, dataGridView_EditionsKeywords);
            frm.Show();
        }

        private void поискИзданияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4(kit1.dataGridView);
            frm.Show();
        }



        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
        }

        private void хронологияИзданийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
        }
        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Size = new Size(800, 400);
            WebBrowser wb = new WebBrowser();
            string curDir = Directory.GetCurrentDirectory();
            wb.Url = new Uri(String.Format("file:///{0}/Resources/help.htm", curDir));
            wb.Dock = DockStyle.Fill;
            frm.Text = "Справка";
            frm.Controls.Add(wb);
            frm.Show();
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}
