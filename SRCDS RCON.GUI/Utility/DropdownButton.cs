﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SRCDS_RCON.Utility
{
	// thanks to Jaex and Sverrir Sigmundarson (https://stackoverflow.com/questions/10803184/windows-forms-button-with-drop-down-menu)
	public class DropdownButton : Button
	{
		[DefaultValue(null), Browsable(true), Category("Dropdown"),
		DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public ContextMenuStrip Menu { get; set; }

		[DefaultValue(20), Browsable(true), Category("Dropdown"),
		DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public int SplitWidth { get; set; }

		[DefaultValue(DashStyle.Dot), Category("Dropdown")]
		public DashStyle SplitStyle { get; set; }

		public DropdownButton()
		{
			SplitWidth = 20;
		}

		protected override void OnMouseDown(MouseEventArgs mevent)
		{
			var splitRect = new Rectangle(Width - SplitWidth, 0, SplitWidth, Height);

			// Figure out if the button click was on the button itself or the menu split
			if (Menu != null &&
				mevent.Button == MouseButtons.Left &&
				splitRect.Contains(mevent.Location))
			{
				Menu.Show(this, 0, Height);    // Shows menu under button
				//Menu.Show(this, mevent.Location); // Shows menu at click location
			}
			else
			{
				base.OnMouseDown(mevent);
			}
		}

		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);

			if (Menu != null && SplitWidth > 0)
			{
				// Draw the arrow glyph on the right side of the button
				int arrowX = ClientRectangle.Width - 14;
				int arrowY = ClientRectangle.Height / 2 - 1;

				var arrowBrush = Enabled ? SystemBrushes.ControlText : SystemBrushes.ButtonShadow;
				var arrows = new[] { new Point(arrowX, arrowY), new Point(arrowX + 7, arrowY), new Point(arrowX + 3, arrowY + 4) };
				pevent.Graphics.FillPolygon(arrowBrush, arrows);

				// Draw a dashed separator on the left of the arrow
				int lineX = ClientRectangle.Width - SplitWidth;
				int lineYFrom = arrowY - 4;
				int lineYTo = arrowY + 8;
				using (var separatorPen = new Pen(Brushes.DarkGray) { DashStyle = SplitStyle })
				{
					pevent.Graphics.DrawLine(separatorPen, lineX, lineYFrom, lineX, lineYTo);
				}
			}
		}
	}
}
