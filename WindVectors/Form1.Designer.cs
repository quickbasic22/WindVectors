
namespace WindVectors
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtAirplaneMagnitude = new System.Windows.Forms.TextBox();
            this.TxtAirplaneDirection = new System.Windows.Forms.TextBox();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.NumUpDownWindMagnitude = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownWindDirection = new System.Windows.Forms.NumericUpDown();
            this.AirplaneGroup = new System.Windows.Forms.GroupBox();
            this.WindGroup = new System.Windows.Forms.GroupBox();
            this.TxtPlaneSpeedResult = new System.Windows.Forms.TextBox();
            this.TxtPlaneDirectionResult = new System.Windows.Forms.TextBox();
            this.AirPlaneResultGroup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownWindMagnitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownWindDirection)).BeginInit();
            this.AirplaneGroup.SuspendLayout();
            this.WindGroup.SuspendLayout();
            this.AirPlaneResultGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtAirplaneMagnitude
            // 
            this.TxtAirplaneMagnitude.Location = new System.Drawing.Point(74, 38);
            this.TxtAirplaneMagnitude.Name = "TxtAirplaneMagnitude";
            this.TxtAirplaneMagnitude.Size = new System.Drawing.Size(179, 23);
            this.TxtAirplaneMagnitude.TabIndex = 0;
            // 
            // TxtAirplaneDirection
            // 
            this.TxtAirplaneDirection.Location = new System.Drawing.Point(74, 80);
            this.TxtAirplaneDirection.Name = "TxtAirplaneDirection";
            this.TxtAirplaneDirection.Size = new System.Drawing.Size(176, 23);
            this.TxtAirplaneDirection.TabIndex = 1;
            // 
            // BtnConvert
            // 
            this.BtnConvert.Location = new System.Drawing.Point(343, 406);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(108, 47);
            this.BtnConvert.TabIndex = 2;
            this.BtnConvert.Text = "Convert";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // NumUpDownWindMagnitude
            // 
            this.NumUpDownWindMagnitude.Location = new System.Drawing.Point(163, 32);
            this.NumUpDownWindMagnitude.Name = "NumUpDownWindMagnitude";
            this.NumUpDownWindMagnitude.Size = new System.Drawing.Size(120, 23);
            this.NumUpDownWindMagnitude.TabIndex = 3;
            // 
            // NumUpDownWindDirection
            // 
            this.NumUpDownWindDirection.Location = new System.Drawing.Point(163, 81);
            this.NumUpDownWindDirection.Name = "NumUpDownWindDirection";
            this.NumUpDownWindDirection.Size = new System.Drawing.Size(120, 23);
            this.NumUpDownWindDirection.TabIndex = 4;
            // 
            // AirplaneGroup
            // 
            this.AirplaneGroup.Controls.Add(this.TxtAirplaneMagnitude);
            this.AirplaneGroup.Controls.Add(this.TxtAirplaneDirection);
            this.AirplaneGroup.Location = new System.Drawing.Point(57, 42);
            this.AirplaneGroup.Name = "AirplaneGroup";
            this.AirplaneGroup.Size = new System.Drawing.Size(300, 153);
            this.AirplaneGroup.TabIndex = 5;
            this.AirplaneGroup.TabStop = false;
            this.AirplaneGroup.Text = "Airplane";
            // 
            // WindGroup
            // 
            this.WindGroup.Controls.Add(this.NumUpDownWindMagnitude);
            this.WindGroup.Controls.Add(this.NumUpDownWindDirection);
            this.WindGroup.Location = new System.Drawing.Point(408, 42);
            this.WindGroup.Name = "WindGroup";
            this.WindGroup.Size = new System.Drawing.Size(301, 153);
            this.WindGroup.TabIndex = 6;
            this.WindGroup.TabStop = false;
            this.WindGroup.Text = "Wind";
            // 
            // TxtPlaneSpeedResult
            // 
            this.TxtPlaneSpeedResult.Location = new System.Drawing.Point(74, 38);
            this.TxtPlaneSpeedResult.Name = "TxtPlaneSpeedResult";
            this.TxtPlaneSpeedResult.Size = new System.Drawing.Size(179, 23);
            this.TxtPlaneSpeedResult.TabIndex = 0;
            // 
            // TxtPlaneDirectionResult
            // 
            this.TxtPlaneDirectionResult.Location = new System.Drawing.Point(74, 80);
            this.TxtPlaneDirectionResult.Name = "TxtPlaneDirectionResult";
            this.TxtPlaneDirectionResult.Size = new System.Drawing.Size(176, 23);
            this.TxtPlaneDirectionResult.TabIndex = 1;
            // 
            // AirPlaneResultGroup
            // 
            this.AirPlaneResultGroup.Controls.Add(this.TxtPlaneSpeedResult);
            this.AirPlaneResultGroup.Controls.Add(this.TxtPlaneDirectionResult);
            this.AirPlaneResultGroup.Location = new System.Drawing.Point(248, 226);
            this.AirPlaneResultGroup.Name = "AirPlaneResultGroup";
            this.AirPlaneResultGroup.Size = new System.Drawing.Size(300, 153);
            this.AirPlaneResultGroup.TabIndex = 7;
            this.AirPlaneResultGroup.TabStop = false;
            this.AirPlaneResultGroup.Text = "Airplane Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 474);
            this.Controls.Add(this.AirPlaneResultGroup);
            this.Controls.Add(this.WindGroup);
            this.Controls.Add(this.AirplaneGroup);
            this.Controls.Add(this.BtnConvert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownWindMagnitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownWindDirection)).EndInit();
            this.AirplaneGroup.ResumeLayout(false);
            this.AirplaneGroup.PerformLayout();
            this.WindGroup.ResumeLayout(false);
            this.AirPlaneResultGroup.ResumeLayout(false);
            this.AirPlaneResultGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAirplaneMagnitude;
        private System.Windows.Forms.TextBox TxtAirplaneDirection;
        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.NumericUpDown NumUpDownWindMagnitude;
        private System.Windows.Forms.NumericUpDown NumUpDownWindDirection;
        private System.Windows.Forms.GroupBox AirplaneGroup;
        private System.Windows.Forms.GroupBox WindGroup;
        private System.Windows.Forms.TextBox TxtPlaneSpeedResult;
        private System.Windows.Forms.TextBox TxtPlaneDirectionResult;
        private System.Windows.Forms.GroupBox AirPlaneResultGroup;
    }
}

