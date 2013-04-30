using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnFacturaClicked (object sender, EventArgs e)
	{

		double num1=float.Parse(this.pro1.Text);
		double num2=float.Parse(this.pro2.Text);
		double num3=float.Parse(this.pro3.Text);
		double sub1 = num1+ num2+num3;
		double iva1 = sub1* .16;
		double total1 = sub1 + iva1;
		this.sub.Text = sub1.ToString();
		this.iva.Text = iva1.ToString();
		this.total.Text = total1.ToString();
	}

	protected void OnLimpiarClicked (object sender, EventArgs e)
	{
		this.pro1.Text="";
		this.pro2.Text="";
		this.pro3.Text = "";
		this.sub.Text = "";
		this.iva.Text = "";
		this.total.Text = "";

	}
}
