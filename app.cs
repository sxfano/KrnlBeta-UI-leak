using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace Krnl
{
	// Token: 0x02000003 RID: 3
	public class App : Application
	{
		// Token: 0x06000003 RID: 3 RVA: 0x000020EC File Offset: 0x000002EC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			base.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020FF File Offset: 0x000002FF
		[STAThread]
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public static void Main()
		{
			App app = new App();
			app.InitializeComponent();
			app.Run();
		}
	}
}
