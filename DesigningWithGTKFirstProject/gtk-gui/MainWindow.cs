
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action FileAction;

	private global::Gtk.Action OpenAction;

	private global::Gtk.Action SaveAsAction;

	private global::Gtk.ToggleAction ExitAction;

	private global::Gtk.Action ActionsAction;

	private global::Gtk.Action StartAction;

	private global::Gtk.ToggleAction StopAction;

	private global::Gtk.VBox vbox1;

	private global::Gtk.MenuBar menubar1;

	private global::Gtk.Fixed fixed1;

	private global::Gtk.Button button1;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.FileAction = new global::Gtk.Action("FileAction", global::Mono.Unix.Catalog.GetString("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString("File");
		w1.Add(this.FileAction, null);
		this.OpenAction = new global::Gtk.Action("OpenAction", global::Mono.Unix.Catalog.GetString("Open"), null, null);
		this.OpenAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Open");
		w1.Add(this.OpenAction, null);
		this.SaveAsAction = new global::Gtk.Action("SaveAsAction", global::Mono.Unix.Catalog.GetString("Save As"), null, null);
		this.SaveAsAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Save As");
		w1.Add(this.SaveAsAction, null);
		this.ExitAction = new global::Gtk.ToggleAction("ExitAction", global::Mono.Unix.Catalog.GetString("Exit"), null, null);
		this.ExitAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Exit");
		w1.Add(this.ExitAction, null);
		this.ActionsAction = new global::Gtk.Action("ActionsAction", global::Mono.Unix.Catalog.GetString("Actions"), null, null);
		this.ActionsAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Actions");
		w1.Add(this.ActionsAction, null);
		this.StartAction = new global::Gtk.Action("StartAction", global::Mono.Unix.Catalog.GetString("Start"), null, null);
		this.StartAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Start");
		w1.Add(this.StartAction, null);
		this.StopAction = new global::Gtk.ToggleAction("StopAction", global::Mono.Unix.Catalog.GetString("Stop"), null, null);
		this.StopAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Stop");
		w1.Add(this.StopAction, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString(@"<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='OpenAction' action='OpenAction'/><menuitem name='SaveAsAction' action='SaveAsAction'/><menuitem name='ExitAction' action='ExitAction'/></menu><menu name='ActionsAction' action='ActionsAction'><menuitem name='StartAction' action='StartAction'/><menuitem name='StopAction' action='StopAction'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox1.Add(this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("GtkButton");
		this.fixed1.Add(this.button1);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
		w3.X = 316;
		w3.Y = 122;
		this.vbox1.Add(this.fixed1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.fixed1]));
		w4.Position = 1;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show();
		this.ExitAction.Toggled += new global::System.EventHandler(this.exit);
		this.button1.Clicked += new global::System.EventHandler(this.clickedToButton);
	}
}
