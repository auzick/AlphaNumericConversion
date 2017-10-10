using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace AlphaNumeric
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			lblNumericValidated.Text = String.Empty;
			lblAlphaValidated.Text = String.Empty;

		}

		private void tbNumeric_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 8)
			{
				e.Handled = false;
			}
			else if (char.IsNumber(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
				SystemSounds.Beep.Play();
			}
		}

		private void tbAlpha_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 8)
			{
				e.Handled = false;
			}
			else if (char.IsLower(e.KeyChar))
			{
				if (Converter.Digits.Contains(e.KeyChar))
				{
					e.Handled = false;
				}
				else
				{
					e.Handled = true;
					SystemSounds.Beep.Play();
				}
			}
		}

		private bool suppressNumericChanged = false;
		private void tbNumeric_TextChanged(object sender, EventArgs e)
		{
			if (tbNumeric.Text == String.Empty)
			{
				ClearFields();
			}
			if (!suppressNumericChanged)
			{
				ConvertNumeric();
			}
			suppressNumericChanged = false;
		}

		private bool suppressAlphaChanged = false;
		private void tbAlpha_TextChanged(object sender, EventArgs e)
		{
			if (tbAlpha.Text == String.Empty)
			{
				ClearFields();
			}
			if (!suppressAlphaChanged)
			{
				ConvertAlpha();
			}
			suppressAlphaChanged = false;
		}

	  private void ConvertNumeric()
	  {
	    lblAlphaValidated.Text = String.Empty;
	    suppressAlphaChanged = true;
	    tbAlpha.Text = Converter.ToAlphaDecimal(ulong.Parse(tbNumeric.Text)).ToString();
	    lblNumericValidated.Text = Converter.ToNumber(tbAlpha.Text).ToString();
	  }

	  private void ConvertAlpha()
	  {

	    lblNumericValidated.Text = String.Empty;
	    suppressNumericChanged = true;
	    tbNumeric.Text = Converter.ToNumber(tbAlpha.Text).ToString();
	    lblAlphaValidated.Text = Converter.ToAlphaDecimal(ulong.Parse(tbNumeric.Text));

	  }


	  private void ClearFields()
		{
			suppressAlphaChanged = true;
			tbAlpha.Text = String.Empty;
			lblAlphaValidated.Text = String.Empty;
			suppressNumericChanged = true;
			tbNumeric.Text = String.Empty;
			lblNumericValidated.Text = String.Empty;
		}

	}
}
