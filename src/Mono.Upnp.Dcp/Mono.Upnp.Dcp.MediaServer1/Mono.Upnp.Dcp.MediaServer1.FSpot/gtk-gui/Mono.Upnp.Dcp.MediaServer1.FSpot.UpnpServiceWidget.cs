
// This file has been generated by the GUI designer. Do not modify.
namespace Mono.Upnp.Dcp.MediaServer1.FSpot
{
	public partial class UpnpServiceWidget
	{
		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView treeview1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Mono.Upnp.Dcp.MediaServer1.FSpot.UpnpServiceWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Mono.Upnp.Dcp.MediaServer1.FSpot.UpnpServiceWidget";
			// Container child Mono.Upnp.Dcp.MediaServer1.FSpot.UpnpServiceWidget.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeview1 = new global::Gtk.TreeView ();
			this.treeview1.CanFocus = true;
			this.treeview1.Name = "treeview1";
			this.treeview1.EnableSearch = false;
			this.treeview1.HeadersVisible = false;
			this.GtkScrolledWindow.Add (this.treeview1);
			this.Add (this.GtkScrolledWindow);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
