// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (c) 2004 Novell, Inc.
//
// Authors:
//	Jordi Mas i Hernandez, jordi@ximian.com
//
//

using System.Runtime.InteropServices;

namespace System.Windows.Forms
{
	[ComVisible (true)]
	public enum Shortcut
	{
		Alt0		= 0x040030,
		Alt1		= 0x040031,
		Alt2		= 0x040032,
		Alt3		= 0x040033,
		Alt4		= 0x040034,
		Alt5		= 0x040035,
		Alt6		= 0x040036,
		Alt7		= 0x040037,
		Alt8		= 0x040038,
		Alt9		= 0x040039,
		AltBksp		= 0x040008,
		AltF1		= 0x040070,
		AltF10		= 0x040079,
		AltF11		= 0x04007A,
		AltF12		= 0x04007B,
		AltF2		= 0x040071,
		AltF3		= 0x040072,
		AltF4		= 0x040073,
		AltF5		= 0x040074,
		AltF6		= 0x040075,
		AltF7		= 0x040076,
		AltF8		= 0x040077,
		AltF9		= 0x040078,
		Ctrl0		= 0x020030,
		Ctrl1		= 0x020031,
		Ctrl2		= 0x020032,
		Ctrl3		= 0x020033,
		Ctrl4		= 0x020034,
		Ctrl5		= 0x020035,
		Ctrl6		= 0x020036,
		Ctrl7		= 0x020037,
		Ctrl8		= 0x020038,
		Ctrl9		= 0x020039,
		CtrlA		= 0x020041,
		CtrlB		= 0x020042,
		CtrlC		= 0x020043,
		CtrlD		= 0x020044,
		CtrlDel		= 0x02002E,
		CtrlE		= 0x020045,
		CtrlF		= 0x020046,
		CtrlF1		= 0x020070,
		CtrlF10		= 0x020079,
		CtrlF11		= 0x02007A,
		CtrlF12		= 0x02007B,
		CtrlF2		= 0x020071,
		CtrlF3		= 0x020072,
		CtrlF4		= 0x020073,
		CtrlF5		= 0x020074,
		CtrlF6		= 0x020075,
		CtrlF7		= 0x020076,
		CtrlF8		= 0x020077,
		CtrlF9		= 0x020078,
		CtrlG		= 0x020047,
		CtrlH		= 0x020048,
		CtrlI		= 0x020049,
		CtrlIns		= 0x02002D,
		CtrlJ		= 0x02004A,
		CtrlK		= 0x02004B,
		CtrlL		= 0x02004C,
		CtrlM		= 0x02004D,
		CtrlN		= 0x02004E,
		CtrlO		= 0x02004F,
		CtrlP		= 0x020050,
		CtrlQ		= 0x020051,
		CtrlR		= 0x020052,
		CtrlS		= 0x020053,
		CtrlShift0	= 0x030030,
		CtrlShift1	= 0x030031,
		CtrlShift2	= 0x030032,
		CtrlShift3	= 0x030033,
		CtrlShift4	= 0x030034,
		CtrlShift5	= 0x030035,
		CtrlShift6	= 0x030036,
		CtrlShift7	= 0x030037,
		CtrlShift8	= 0x030038,
		CtrlShift9	= 0x030039,
		CtrlShiftA	= 0x030041,
		CtrlShiftB	= 0x030042,
		CtrlShiftC	= 0x030043,
		CtrlShiftD	= 0x030044,
		CtrlShiftE	= 0x030045,
		CtrlShiftF	= 0x030046,
		CtrlShiftF1	= 0x030070,
		CtrlShiftF10	= 0x030079,
		CtrlShiftF11	= 0x03007A,
		CtrlShiftF12	= 0x03007B,
		CtrlShiftF2	= 0x030071,
		CtrlShiftF3	= 0x030072,
		CtrlShiftF4	= 0x030073,
		CtrlShiftF5	= 0x030074,
		CtrlShiftF6	= 0x030075,
		CtrlShiftF7	= 0x030076,
		CtrlShiftF8	= 0x030077,
		CtrlShiftF9	= 0x030078,
		CtrlShiftG	= 0x030047,
		CtrlShiftH	= 0x030048,
		CtrlShiftI	= 0x030049,
		CtrlShiftJ	= 0x03004A,
		CtrlShiftK	= 0x03004B,
		CtrlShiftL	= 0x03004C,
		CtrlShiftM	= 0x03004D,
		CtrlShiftN	= 0x03004E,
		CtrlShiftO	= 0x03004F,
		CtrlShiftP	= 0x030050,
		CtrlShiftQ	= 0x030051,
		CtrlShiftR	= 0x030052,
		CtrlShiftS	= 0x030053,
		CtrlShiftT	= 0x030054,
		CtrlShiftU	= 0x030055,
		CtrlShiftV	= 0x030056,
		CtrlShiftW	= 0x030057,
		CtrlShiftX	= 0x030058,
		CtrlShiftY	= 0x030059,
		CtrlShiftZ	= 0x03005A,
		CtrlT		= 0x020054,
		CtrlU		= 0x020055,
		CtrlV		= 0x020056,
		CtrlW		= 0x020057,
		CtrlX		= 0x020058,
		CtrlY		= 0x020059,
		CtrlZ		= 0x02005A,
		Del		= 0x00002E,
		F1		= 0x000070,
		F10		= 0x000079,
		F11		= 0x00007A,
		F12		= 0x00007B,
		F2		= 0x000071,
		F3		= 0x000072,
		F4		= 0x000073,
		F5		= 0x000074,
		F6		= 0x000075,
		F7		= 0x000076,
		F8		= 0x000077,
		F9		= 0x000078,
		Ins		= 0x00002D,
		None		= 0x000000,
		ShiftDel	= 65582,
		ShiftF1		= 65648,
		ShiftF10	= 65657,
		ShiftF11	= 65658,
		ShiftF12	= 65659,
		ShiftF2		= 65649,
		ShiftF3		= 65650,
		ShiftF4		= 65651,
		ShiftF5		= 65652,
		ShiftF6		= 65653,
		ShiftF7		= 65654,
		ShiftF8		= 65655,
		ShiftF9		= 65656,
		ShiftIns	= 65581,
	}
}


