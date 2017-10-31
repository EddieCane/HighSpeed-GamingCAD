namespace WindowsFormsApplication1
{
    partial class FireEmsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FireEmsForm));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(152, 458);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 5;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(103)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(103)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1224, 341);
            this.dataGridView2.TabIndex = 10;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column7.HeaderText = "Call ID";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 44;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Time Stamp";
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column9.HeaderText = "Call Status";
            this.Column9.Items.AddRange(new object[] {
            " ",
            "Pending",
            "Dispatched",
            "On-Scene",
            "Cleared",
            "Canceled",
            "Bolo\'d"});
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "Call Details";
            this.Column10.Name = "Column10";
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "Arival Time";
            this.Column11.Name = "Column11";
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.HeaderText = "Cleared Time";
            this.Column12.Name = "Column12";
            this.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Active Calls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dispatch";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(103)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(103)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(103)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(103)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(152, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 5;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(103)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(103)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1224, 400);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Unit Number";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 104;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column2.HeaderText = "Sub-Division";
            this.Column2.Items.AddRange(new object[] {
            "",
            "Administration\t\t\t\t\t\t\t\t\t\t\t\t\t\t",
            "Patrol\t\t\t\t\t\t\t\t\t\t\t\t\t\t",
            "Traffic Enforcement\t\t\t\t\t\t\t\t\t\t\t\t\t\t",
            "K-9\t\t\t\t\t\t\t\t\t\t\t\t\t\t",
            "Aviation\t\t\t\t\t\t\t\t\t\t\t\t\t\t",
            "Criminal Investigations\t\t\t\t\t\t\t\t\t\t\t\t\t\t",
            "Crime Suppression Unit\t\t\t\t\t\t\t\t\t\t\t\t\t\t",
            "Tactical Response Unit\t\t\t\t\t\t\t\t\t\t\t\t\t\t",
            "Academy"});
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column3.HeaderText = "Unit Status";
            this.Column3.Items.AddRange(new object[] {
            " ",
            "Out Of Service",
            "In Service",
            "Available",
            "Unavailable",
            "Meal Break",
            "Code 0",
            "En-Route",
            "On Scene",
            "Officer Down",
            "Civilian",
            "Traffic Stop",
            "Busy",
            "Transporting Suspect",
            "Enroute Station",
            "Briefing",
            "Foot Pursuit",
            "V Pursuit"});
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column4.HeaderText = "Location";
            this.Column4.Items.AddRange(new object[] {
            " ",
            "------Los Santos County------",
            "Abattoir Avenue",
            "Abe Milton Parkway",
            "Ace Jones Drive",
            "Adam\'s Apple Boulevard",
            "Aguja Street",
            "Alta Place",
            "Alta Street",
            "Amarillo Vista",
            "Amarillo Way",
            "Americano Way",
            "Atlee Street",
            "Autopia Parkway",
            "Banham Canyon Drive",
            "Barbareno Road",
            "Bay City Avenue",
            "Bay City Incline",
            "Baytree Canyon Road",
            "Boulevard Del Perro",
            "Bridge Street",
            "Brouge Avenue",
            "Buccaneer Way",
            "Caesars Place",
            "Calais Avenue",
            "Capital Boulevard",
            "Carcer Way",
            "Carson Avenue",
            "Chum Street",
            "Chupacabra Street",
            "Clinton Avenue",
            "Cockingend Drive",
            "Conquistador Street",
            "Cortes Street",
            "Cougar Avenue",
            "Covenant Avenue",
            "Cox Way",
            "Crusade Road",
            "Davis Avenue",
            "Decker Street",
            "Didion Drive",
            "Dorset Drive",
            "Dorset Place",
            "Dry Dock Street",
            "Dunstable Drive",
            "Dunstable Lane",
            "Dutch London Street",
            "Eastbourne Way",
            "East Galileo Avenue",
            "East Mirror Drive",
            "Eclipse Boulevard",
            "Edwood Way",
            "Elgin Avenue",
            "El Burro Boulevard",
            "El Rancho Boulevard",
            "Equality Way",
            "Exceptionalists Way",
            "Fantastic Place",
            "Fenwell Place",
            "Forum Drive",
            "Fudge Avenue",
            "Fudge Lane",
            "Galileo Road",
            "Gentry Lane",
            "Ginger Street",
            "Glory Way",
            "Goma Street",
            "Greenwich Parkway",
            "Greenwich Place",
            "Greenwich Way",
            "Grove Street",
            "Hanger Way",
            "Hangman Avenue",
            "Hardy Way",
            "Hawick Avenue",
            "Heritage Way",
            "Hillcrest Avenue",
            "Hillcrest Ridge Access Road",
            "Imagination Court",
            "Ineseno Road",
            "Invention Court",
            "Innocence Boulevard",
            "Jamestown Avenue",
            "Jamestown Street",
            "Kimble Hill Drive",
            "Kortz Drive",
            "Labor Place",
            "Laguna Place",
            "Lake Vinewood Est",
            "Lake Vinewood Drive",
            "Las Lagunas Boulevard",
            "La Puerta Street",
            "Liberty Street",
            "Lindsay Circus",
            "Little Bighorn Avenue",
            "Los Santos Boulevard",
            "Low Power Street",
            "Macdonald Street",
            "Mad Wayne Thunder Drive",
            "Magellan Avenue",
            "Marathon Avenue",
            "Marlowe Drive",
            "Melanoma Street",
            "Meteor Street",
            "Milton Road",
            "Mirror Place",
            "Mirror Park Boulevard",
            "Morningwood Boulevard",
            "Mount Haan Drive",
            "Mount Haan Road",
            "Mount Vinewood Drive",
            "Movie Star Way",
            "Mutiny Road",
            "New Empire Way",
            "Normandy Drive",
            "Nikola Avenue,",
            "Nikola Place",
            "North Archer Avenue",
            "North Conker Avenue",
            "North Sheldon Avenue",
            "North Sheldon Drive",
            "North Rockford Drive",
            "Occupation Avenue",
            "Orchardville Avenue",
            "Palomino Avenue",
            "Peaceful Street",
            "Perth Street",
            "Picture Perfect Drive",
            "Plaice Place",
            "Playa Vista",
            "Popular Street",
            "Portola Drive",
            "Power Street",
            "Prosperity Street",
            "Prosperity Street Promenade",
            "Red Desert Avenue",
            "Richman Street",
            "Rockford Drive",
            "Roy Lowenstein Boulevard",
            "Rub Street",
            "Sam Austin Drive",
            "San Andreas Avenue",
            "San Andreas Boulevard",
            "Sandcastle Way",
            "San Vitas Street",
            "San Vitus Boulevard",
            "Senora Road",
            "Shank Street",
            "Signal Street",
            "Sinner Street",
            "Sinners Passage",
            "South Arsenal Street",
            "South Boulevard Del Perro",
            "South Mo Milton Drive",
            "South Rockford Drive",
            "South Shambles Street",
            "Spanish Avenue",
            "Steele Way",
            "Strangeways Drive",
            "Strawberry Avenue",
            "Supply Street",
            "Sustancia Road",
            "Swiss Street",
            "Tackle Street",
            "Tangerine Street",
            "Tongva Drive",
            "Tower Way",
            "Tug Street",
            "Utopia Gardens",
            "Vespucci Boulevard",
            "Vine Drive",
            "Vinewood Boulevard",
            "Vinewood Park Drive",
            "Vitus Street",
            "Voodoo Place",
            "West Eclipse Boulevard",
            "West Galileo Avenue",
            "West Mirror Drive",
            "Whispymound Drive",
            "Wild Oats Drive",
            "York Street",
            "Zancudo Barranca",
            "Zancudo Road",
            "------Blaine County------",
            "Algonquin Boulevard",
            "Alhambra Drive",
            "Armadillo Avenue",
            "Baytree Canyon Road",
            "Calafia Road",
            "Cascabel Avenue",
            "Cat Claw Avenue",
            "Chianski Passage",
            "Cholla Road",
            "Cholla Springs Avenue",
            "Duluoz Avenue",
            "East Joshua Road",
            "Fort Zancudo Approach Road",
            "Galileo Road",
            "Grapeseed Avenue",
            "Grapeseed Main Street",
            "Joad Lane",
            "Joshua Road",
            "Lesbos Lane",
            "Lolita Avenue",
            "Marina Drive",
            "Meringue Lane",
            "Mount Haan Road",
            "Mountain View Drive",
            "Niland Avenue",
            "North Calafia Way",
            "Nowhere Road",
            "O\'Neil Way",
            "Paleto Boulevard",
            "Panorama Drive",
            "Procopio Drive",
            "Procopio Promenade",
            "Pyrite Avenue",
            "Seaview Road",
            "Senora Way",
            "Smoke Tree Road",
            "Union Road",
            "Zancudo A",
            "Interstate 1",
            "Interstate 2",
            "Interstate 4",
            "Interstate 5",
            "Route 1",
            "Route 11",
            "Route 13",
            "Route 14",
            "Route 15",
            "Route 16",
            "Route 17",
            "Route 18",
            "Route 19",
            "Route 20",
            "Route 22",
            "Route 23",
            "Route 68"});
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column5.HeaderText = "Cross Street";
            this.Column5.Items.AddRange(new object[] {
            " ",
            "------Los Santos County------",
            "Abattoir Avenue",
            "Abe Milton Parkway",
            "Ace Jones Drive",
            "Adam\'s Apple Boulevard",
            "Aguja Street",
            "Alta Place",
            "Alta Street",
            "Amarillo Vista",
            "Amarillo Way",
            "Americano Way",
            "Atlee Street",
            "Autopia Parkway",
            "Banham Canyon Drive",
            "Barbareno Road",
            "Bay City Avenue",
            "Bay City Incline",
            "Baytree Canyon Road",
            "Boulevard Del Perro",
            "Bridge Street",
            "Brouge Avenue",
            "Buccaneer Way",
            "Caesars Place",
            "Calais Avenue",
            "Capital Boulevard",
            "Carcer Way",
            "Carson Avenue",
            "Chum Street",
            "Chupacabra Street",
            "Clinton Avenue",
            "Cockingend Drive",
            "Conquistador Street",
            "Cortes Street",
            "Cougar Avenue",
            "Covenant Avenue",
            "Cox Way",
            "Crusade Road",
            "Davis Avenue",
            "Decker Street",
            "Didion Drive",
            "Dorset Drive",
            "Dorset Place",
            "Dry Dock Street",
            "Dunstable Drive",
            "Dunstable Lane",
            "Dutch London Street",
            "Eastbourne Way",
            "East Galileo Avenue",
            "East Mirror Drive",
            "Eclipse Boulevard",
            "Edwood Way",
            "Elgin Avenue",
            "El Burro Boulevard",
            "El Rancho Boulevard",
            "Equality Way",
            "Exceptionalists Way",
            "Fantastic Place",
            "Fenwell Place",
            "Forum Drive",
            "Fudge Avenue",
            "Fudge Lane",
            "Galileo Road",
            "Gentry Lane",
            "Ginger Street",
            "Glory Way",
            "Goma Street",
            "Greenwich Parkway",
            "Greenwich Place",
            "Greenwich Way",
            "Grove Street",
            "Hanger Way",
            "Hangman Avenue",
            "Hardy Way",
            "Hawick Avenue",
            "Heritage Way",
            "Hillcrest Avenue",
            "Hillcrest Ridge Access Road",
            "Imagination Court",
            "Ineseno Road",
            "Invention Court",
            "Innocence Boulevard",
            "Jamestown Avenue",
            "Jamestown Street",
            "Kimble Hill Drive",
            "Kortz Drive",
            "Labor Place",
            "Laguna Place",
            "Lake Vinewood Est",
            "Lake Vinewood Drive",
            "Las Lagunas Boulevard",
            "La Puerta Street",
            "Liberty Street",
            "Lindsay Circus",
            "Little Bighorn Avenue",
            "Los Santos Boulevard",
            "Low Power Street",
            "Macdonald Street",
            "Mad Wayne Thunder Drive",
            "Magellan Avenue",
            "Marathon Avenue",
            "Marlowe Drive",
            "Melanoma Street",
            "Meteor Street",
            "Milton Road",
            "Mirror Place",
            "Mirror Park Boulevard",
            "Morningwood Boulevard",
            "Mount Haan Drive",
            "Mount Haan Road",
            "Mount Vinewood Drive",
            "Movie Star Way",
            "Mutiny Road",
            "New Empire Way",
            "Normandy Drive",
            "Nikola Avenue,",
            "Nikola Place",
            "North Archer Avenue",
            "North Conker Avenue",
            "North Sheldon Avenue",
            "North Sheldon Drive",
            "North Rockford Drive",
            "Occupation Avenue",
            "Orchardville Avenue",
            "Palomino Avenue",
            "Peaceful Street",
            "Perth Street",
            "Picture Perfect Drive",
            "Plaice Place",
            "Playa Vista",
            "Popular Street",
            "Portola Drive",
            "Power Street",
            "Prosperity Street",
            "Prosperity Street Promenade",
            "Red Desert Avenue",
            "Richman Street",
            "Rockford Drive",
            "Roy Lowenstein Boulevard",
            "Rub Street",
            "Sam Austin Drive",
            "San Andreas Avenue",
            "San Andreas Boulevard",
            "Sandcastle Way",
            "San Vitas Street",
            "San Vitus Boulevard",
            "Senora Road",
            "Shank Street",
            "Signal Street",
            "Sinner Street",
            "Sinners Passage",
            "South Arsenal Street",
            "South Boulevard Del Perro",
            "South Mo Milton Drive",
            "South Rockford Drive",
            "South Shambles Street",
            "Spanish Avenue",
            "Steele Way",
            "Strangeways Drive",
            "Strawberry Avenue",
            "Supply Street",
            "Sustancia Road",
            "Swiss Street",
            "Tackle Street",
            "Tangerine Street",
            "Tongva Drive",
            "Tower Way",
            "Tug Street",
            "Utopia Gardens",
            "Vespucci Boulevard",
            "Vine Drive",
            "Vinewood Boulevard",
            "Vinewood Park Drive",
            "Vitus Street",
            "Voodoo Place",
            "West Eclipse Boulevard",
            "West Galileo Avenue",
            "West Mirror Drive",
            "Whispymound Drive",
            "Wild Oats Drive",
            "York Street",
            "Zancudo Barranca",
            "Zancudo Road",
            "------Blaine County------",
            "Algonquin Boulevard",
            "Alhambra Drive",
            "Armadillo Avenue",
            "Baytree Canyon Road",
            "Calafia Road",
            "Cascabel Avenue",
            "Cat Claw Avenue",
            "Chianski Passage",
            "Cholla Road",
            "Cholla Springs Avenue",
            "Duluoz Avenue",
            "East Joshua Road",
            "Fort Zancudo Approach Road",
            "Galileo Road",
            "Grapeseed Avenue",
            "Grapeseed Main Street",
            "Joad Lane",
            "Joshua Road",
            "Lesbos Lane",
            "Lolita Avenue",
            "Marina Drive",
            "Meringue Lane",
            "Mount Haan Road",
            "Mountain View Drive",
            "Niland Avenue",
            "North Calafia Way",
            "Nowhere Road",
            "O\'Neil Way",
            "Paleto Boulevard",
            "Panorama Drive",
            "Procopio Drive",
            "Procopio Promenade",
            "Pyrite Avenue",
            "Seaview Road",
            "Senora Way",
            "Smoke Tree Road",
            "Union Road",
            "Zancudo A",
            "Interstate 1",
            "Interstate 2",
            "Interstate 4",
            "Interstate 5",
            "Route 1",
            "Route 11",
            "Route 13",
            "Route 14",
            "Route 15",
            "Route 16",
            "Route 17",
            "Route 18",
            "Route 19",
            "Route 20",
            "Route 22",
            "Route 23",
            "Route 68"});
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Call Details";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(103)))), ((int)(((byte)(177)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.button6.Location = new System.Drawing.Point(12, 749);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 50);
            this.button6.TabIndex = 14;
            this.button6.Text = "Choose A Department";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1388, 815);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(103)))), ((int)(((byte)(177)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.Text = "Fire/EMS";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        public System.Windows.Forms.DataGridViewComboBoxColumn Column9;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        public System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        public System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        public System.Windows.Forms.DataGridViewComboBoxColumn Column5;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        public System.Windows.Forms.Button button6;

    }
}