using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public class Form1 : Form
	{
		private IContainer components;

		private Jingo bob = new Jingo();

		public Form1 formular;

		private Jongo trælle = new Jongo();

		private Panel panel1;

		private Button button1;

		private List<Afmagt> bollemælk;

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			panel1 = new System.Windows.Forms.Panel();
			button1 = new System.Windows.Forms.Button();
			SuspendLayout();
			panel1.Location = new System.Drawing.Point(12, 45);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(869, 450);
			panel1.TabIndex = 1;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			button1.Location = new System.Drawing.Point(825, 12);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 2;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(bongo);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(912, 507);
			base.Controls.Add(button1);
			base.Controls.Add(panel1);
			base.Name = "Form1";
			Text = "Form1";
			ResumeLayout(performLayout: false);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			panel1_Paint(0, e);
			base.OnPaint(e);
		}

		public void newJongo()
		{
			trælle = new Jongo();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		public void jongoTime()
		{
			Graphics graphics = panel1.CreateGraphics();
			for (int num = 5; num >= 0; num--)
			{
				for (int num2 = trælle.getJohn().Count - 1; num2 > 0; num2--)
				{
					trælle.getJohn()[num2].changeCourse();
					trælle.getJohn()[num2].moodChange(trælle.getJohn()[num2].changeCourse(), new Juklas());
					graphics.FillEllipse(new SolidBrush(trælle.getJohn()[num2].getColor()), new Rectangle(trælle.getJohn()[num2].getX(), trælle.getJohn()[num2].getY(), trælle.getJohn()[num2].getSize(), trælle.getJohn()[num2].getSize()));
					graphics.FillEllipse(new SolidBrush(trælle.getJohn()[num2].jingoTime(new Juklas(4)).getMood()), new Jingo().getSizeRectangle());
				}
			}
		}

		public Form1 sendForm()
		{
			return this;
		}

		private int patrol()
		{
			throw new NotImplementedException();
		}

		public Form1()
		{
			InitializeComponent();
			jongoTime();
			fillJoin();
		}

		private void bongo(object sender, EventArgs e)
		{
			button1.Text = "Hej";
			for (int num = 10; num > 0; num--)
			{
				fillJoin();
				new BolleHeaven().updateTegnsæt();
				jongoTime();
			}
			newJongo();
		}

		private void fillJoin()
		{
			if (new Jingo().showBirth().Second > 4)
			{
				new Movement().joinForce();
			}
			else
			{
				new BolleHeaven().bolledej(0, 4);
			}
		}

		public void fillArrayBollemælk()
		{
			foreach (Afmagt item in bollemælk)
			{
				Bongo bongo = new Bongo();
				bongo.populationControl(new Jingo().changeCourse().jingoTime(new Juklas()).affectMood(4, new Juklas()), new Mood(), item.afMagt(5), new Token(), new PlotCourse().typeHente());
			}
			Jingo jingo = new Jingo();
			jingo.showBirth();
			jingo.jingoTime(tidspres());
			jingo.timesTwenty(DateTime.Now);
		}

		private Juklas tidspres()
		{
			throw new NotImplementedException();
		}
	}
}
