namespace RPG
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Arena = new System.Windows.Forms.TableLayoutPanel();
            this.HeroContainer = new System.Windows.Forms.TableLayoutPanel();
            this.HeroArmor = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.HeroHealth = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Hero = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.HeroLevel = new System.Windows.Forms.Label();
            this.EnemyContainer = new System.Windows.Forms.TableLayoutPanel();
            this.EnemyArmor = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.EnemyHealth = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Enemy = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.EnemyLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.HeroLegs = new System.Windows.Forms.PictureBox();
            this.HeroBody = new System.Windows.Forms.PictureBox();
            this.HeroHead = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.Arena.SuspendLayout();
            this.HeroContainer.SuspendLayout();
            this.HeroArmor.SuspendLayout();
            this.HeroHealth.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Hero.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.EnemyContainer.SuspendLayout();
            this.EnemyArmor.SuspendLayout();
            this.EnemyHealth.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Enemy.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeroLegs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroHead)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Arena, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(778, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "10м";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(0, 641);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(784, 20);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 10;
            // 
            // Arena
            // 
            this.Arena.ColumnCount = 2;
            this.Arena.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Arena.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Arena.Controls.Add(this.EnemyContainer, 0, 0);
            this.Arena.Controls.Add(this.HeroContainer, 0, 0);
            this.Arena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Arena.Location = new System.Drawing.Point(3, 33);
            this.Arena.Name = "Arena";
            this.Arena.RowCount = 1;
            this.Arena.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Arena.Size = new System.Drawing.Size(778, 605);
            this.Arena.TabIndex = 2;
            // 
            // HeroContainer
            // 
            this.HeroContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.HeroContainer.ColumnCount = 1;
            this.HeroContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeroContainer.Controls.Add(this.HeroArmor, 0, 1);
            this.HeroContainer.Controls.Add(this.HeroHealth, 0, 0);
            this.HeroContainer.Controls.Add(this.panel1, 0, 2);
            this.HeroContainer.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.HeroContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeroContainer.Location = new System.Drawing.Point(3, 3);
            this.HeroContainer.Name = "HeroContainer";
            this.HeroContainer.RowCount = 4;
            this.HeroContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.HeroContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.HeroContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeroContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.HeroContainer.Size = new System.Drawing.Size(383, 599);
            this.HeroContainer.TabIndex = 0;
            // 
            // HeroArmor
            // 
            this.HeroArmor.ColumnCount = 2;
            this.HeroArmor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeroArmor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeroArmor.Controls.Add(this.label3, 0, 0);
            this.HeroArmor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeroArmor.Location = new System.Drawing.Point(1, 32);
            this.HeroArmor.Margin = new System.Windows.Forms.Padding(0);
            this.HeroArmor.Name = "HeroArmor";
            this.HeroArmor.RowCount = 1;
            this.HeroArmor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeroArmor.Size = new System.Drawing.Size(381, 30);
            this.HeroArmor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 30);
            this.label3.TabIndex = 0;
            // 
            // HeroHealth
            // 
            this.HeroHealth.ColumnCount = 2;
            this.HeroHealth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeroHealth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeroHealth.Controls.Add(this.label2, 0, 0);
            this.HeroHealth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeroHealth.Location = new System.Drawing.Point(1, 1);
            this.HeroHealth.Margin = new System.Windows.Forms.Padding(0);
            this.HeroHealth.Name = "HeroHealth";
            this.HeroHealth.RowCount = 1;
            this.HeroHealth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeroHealth.Size = new System.Drawing.Size(381, 30);
            this.HeroHealth.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 30);
            this.label2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Hero);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 438);
            this.panel1.TabIndex = 2;
            // 
            // Hero
            // 
            this.Hero.ColumnCount = 1;
            this.Hero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Hero.Controls.Add(this.HeroLegs, 0, 2);
            this.Hero.Controls.Add(this.HeroBody, 0, 1);
            this.Hero.Controls.Add(this.HeroHead, 0, 0);
            this.Hero.Location = new System.Drawing.Point(24, 3);
            this.Hero.Name = "Hero";
            this.Hero.RowCount = 3;
            this.Hero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Hero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Hero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Hero.Size = new System.Drawing.Size(317, 465);
            this.Hero.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.button3, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.HeroLevel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 511);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(375, 84);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // HeroLevel
            // 
            this.HeroLevel.AutoSize = true;
            this.HeroLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeroLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeroLevel.Location = new System.Drawing.Point(3, 0);
            this.HeroLevel.Name = "HeroLevel";
            this.HeroLevel.Size = new System.Drawing.Size(87, 84);
            this.HeroLevel.TabIndex = 0;
            this.HeroLevel.Text = "1Ур.";
            this.HeroLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnemyContainer
            // 
            this.EnemyContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.EnemyContainer.ColumnCount = 1;
            this.EnemyContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EnemyContainer.Controls.Add(this.EnemyArmor, 0, 1);
            this.EnemyContainer.Controls.Add(this.EnemyHealth, 0, 0);
            this.EnemyContainer.Controls.Add(this.panel2, 0, 2);
            this.EnemyContainer.Controls.Add(this.tableLayoutPanel7, 0, 3);
            this.EnemyContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnemyContainer.Location = new System.Drawing.Point(392, 3);
            this.EnemyContainer.Name = "EnemyContainer";
            this.EnemyContainer.RowCount = 4;
            this.EnemyContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.EnemyContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.EnemyContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EnemyContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.EnemyContainer.Size = new System.Drawing.Size(383, 599);
            this.EnemyContainer.TabIndex = 1;
            // 
            // EnemyArmor
            // 
            this.EnemyArmor.ColumnCount = 2;
            this.EnemyArmor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnemyArmor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnemyArmor.Controls.Add(this.label4, 1, 0);
            this.EnemyArmor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnemyArmor.Location = new System.Drawing.Point(1, 32);
            this.EnemyArmor.Margin = new System.Windows.Forms.Padding(0);
            this.EnemyArmor.Name = "EnemyArmor";
            this.EnemyArmor.RowCount = 1;
            this.EnemyArmor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnemyArmor.Size = new System.Drawing.Size(381, 30);
            this.EnemyArmor.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(190, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 30);
            this.label4.TabIndex = 0;
            // 
            // EnemyHealth
            // 
            this.EnemyHealth.ColumnCount = 2;
            this.EnemyHealth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnemyHealth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnemyHealth.Controls.Add(this.label5, 1, 0);
            this.EnemyHealth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnemyHealth.Location = new System.Drawing.Point(1, 1);
            this.EnemyHealth.Margin = new System.Windows.Forms.Padding(0);
            this.EnemyHealth.Name = "EnemyHealth";
            this.EnemyHealth.RowCount = 1;
            this.EnemyHealth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnemyHealth.Size = new System.Drawing.Size(381, 30);
            this.EnemyHealth.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Enemy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 438);
            this.panel2.TabIndex = 2;
            // 
            // Enemy
            // 
            this.Enemy.ColumnCount = 1;
            this.Enemy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Enemy.Controls.Add(this.button6, 0, 2);
            this.Enemy.Controls.Add(this.button5, 0, 1);
            this.Enemy.Controls.Add(this.button4, 0, 0);
            this.Enemy.Location = new System.Drawing.Point(24, 3);
            this.Enemy.Name = "Enemy";
            this.Enemy.RowCount = 3;
            this.Enemy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Enemy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Enemy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Enemy.Size = new System.Drawing.Size(317, 465);
            this.Enemy.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Controls.Add(this.EnemyLevel, 3, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 511);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(375, 84);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // EnemyLevel
            // 
            this.EnemyLevel.AutoSize = true;
            this.EnemyLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnemyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnemyLevel.Location = new System.Drawing.Point(282, 0);
            this.EnemyLevel.Name = "EnemyLevel";
            this.EnemyLevel.Size = new System.Drawing.Size(90, 84);
            this.EnemyLevel.TabIndex = 0;
            this.EnemyLevel.Text = "1Ур.";
            this.EnemyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Maroon;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(190, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 30);
            this.label5.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::RPG.Properties.Resources.SpartanecBody;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(0, 155);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(317, 155);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::RPG.Properties.Resources.SpartanecLegs;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(0, 310);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(317, 155);
            this.button6.TabIndex = 2;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::RPG.Properties.Resources.SpartanecHead;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(317, 155);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // HeroLegs
            // 
            this.HeroLegs.BackgroundImage = global::RPG.Properties.Resources.HoreLegs;
            this.HeroLegs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeroLegs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeroLegs.Location = new System.Drawing.Point(0, 310);
            this.HeroLegs.Margin = new System.Windows.Forms.Padding(0);
            this.HeroLegs.Name = "HeroLegs";
            this.HeroLegs.Size = new System.Drawing.Size(317, 155);
            this.HeroLegs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeroLegs.TabIndex = 2;
            this.HeroLegs.TabStop = false;
            this.HeroLegs.Click += new System.EventHandler(this.SmenaBloka);
            // 
            // HeroBody
            // 
            this.HeroBody.BackgroundImage = global::RPG.Properties.Resources.HoreBody;
            this.HeroBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeroBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeroBody.Location = new System.Drawing.Point(0, 155);
            this.HeroBody.Margin = new System.Windows.Forms.Padding(0);
            this.HeroBody.Name = "HeroBody";
            this.HeroBody.Size = new System.Drawing.Size(317, 155);
            this.HeroBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeroBody.TabIndex = 1;
            this.HeroBody.TabStop = false;
            this.HeroBody.Click += new System.EventHandler(this.SmenaBloka);
            // 
            // HeroHead
            // 
            this.HeroHead.BackgroundImage = global::RPG.Properties.Resources.HoreHead;
            this.HeroHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeroHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeroHead.Image = global::RPG.Properties.Resources.Sheald;
            this.HeroHead.Location = new System.Drawing.Point(0, 0);
            this.HeroHead.Margin = new System.Windows.Forms.Padding(0);
            this.HeroHead.Name = "HeroHead";
            this.HeroHead.Size = new System.Drawing.Size(317, 155);
            this.HeroHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HeroHead.TabIndex = 0;
            this.HeroHead.TabStop = false;
            this.HeroHead.Click += new System.EventHandler(this.SmenaBloka);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::RPG.Properties.Resources.Arrow;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(279, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 84);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::RPG.Properties.Resources.Magic;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(186, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 84);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::RPG.Properties.Resources.Swoard;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(93, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 84);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Arena.ResumeLayout(false);
            this.HeroContainer.ResumeLayout(false);
            this.HeroArmor.ResumeLayout(false);
            this.HeroArmor.PerformLayout();
            this.HeroHealth.ResumeLayout(false);
            this.HeroHealth.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Hero.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.EnemyContainer.ResumeLayout(false);
            this.EnemyArmor.ResumeLayout(false);
            this.EnemyArmor.PerformLayout();
            this.EnemyHealth.ResumeLayout(false);
            this.EnemyHealth.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.Enemy.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeroLegs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroHead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TableLayoutPanel Arena;
        private System.Windows.Forms.TableLayoutPanel HeroContainer;
        private System.Windows.Forms.TableLayoutPanel HeroArmor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel HeroHealth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel Hero;
        private System.Windows.Forms.PictureBox HeroLegs;
        private System.Windows.Forms.PictureBox HeroBody;
        private System.Windows.Forms.PictureBox HeroHead;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label HeroLevel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel EnemyContainer;
        private System.Windows.Forms.TableLayoutPanel EnemyArmor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel EnemyHealth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel Enemy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label EnemyLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}

