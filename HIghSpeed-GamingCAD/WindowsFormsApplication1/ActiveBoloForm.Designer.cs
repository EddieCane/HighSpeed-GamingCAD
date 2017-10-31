namespace WindowsFormsApplication1
{
    partial class ActiveBoloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveBoloForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(103)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(103)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 5;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(1069, 547);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Time Stamp";
            this.Column1.Name = "Column1";
            this.Column1.Width = 88;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Car Description";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Suspect Description";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column4.HeaderText = "Last Seen";
            this.Column4.Items.AddRange(new object[] {
            " ",
            "------Los Santos------",
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
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column5.HeaderText = "Cross Street";
            this.Column5.Items.AddRange(new object[] {
            " ",
            "------Los Santos------",
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
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column6.HeaderText = "Department Issued";
            this.Column6.Items.AddRange(new object[] {
            " ",
            "SAST",
            "LSPD",
            "LSSO",
            "BCSO",
            "Admin"});
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Details";
            this.Column7.Name = "Column7";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1097, 575);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(103)))), ((int)(((byte)(177)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Active Bolos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}