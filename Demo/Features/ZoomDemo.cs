/*****************************************************************************
 * 
 * ReoGrid - .NET Spreadsheet Control
 * 
 * https://reogrid.net
 *
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
 * KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
 * PURPOSE.
 *
 * ReoGrid and ReoGrid Demo project is released under MIT license.
 *
 * Copyright (c) 2012-2021 Jing Lu <jingwood at unvell.com>
 * Copyright (c) 2012-2016 unvell.com, all rights reserved.
 * 
 ****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace unvell.ReoGrid.Demo.Features
{
	public partial class ZoomDemo : UserControl
	{
		private Worksheet worksheet;

		public ZoomDemo()
		{
			InitializeComponent();

			this.worksheet = grid.CurrentWorksheet;

			for (int r = 0; r < 50; r++)
			{
				for (int c = 0; c < 20; c++)
				{
					worksheet[r, c] = (r + 1) * (c + 1);
				}
			}
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			worksheet.ScaleFactor = trackBar1.Value / 10f;

			label2.Text = "Current: " + (worksheet.ScaleFactor * 100) + "%";
		}
	}
}
