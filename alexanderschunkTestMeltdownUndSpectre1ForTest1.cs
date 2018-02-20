/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Alexander
 * Datum: 19.02.2018
 * Zeit: 15:09
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;


namespace AlexanderSchunkMeltdownUndSpectreDirectXTest1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//Alexander Schunk Meltdown Test DirectX und Direct3D für Windows 2018
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			MessageBox.Show("Alexander Schunk Meltdown Test 3D", "Meltdown Test 3D", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}
