using Terraria;
using Terraria.IO;
using TerrariaApi.Server;
using TShockAPI;

namespace ExportSsc;

/// <summary>
/// The main plugin class should always be decorated with an ApiVersion attribute. The current API version is 1.25.
[ApiVersion(2, 1)]
public class ExportSsc : TerrariaPlugin
{
	public override string Name => "ExportSSC";

	public override Version Version => new Version(0, 1, 0);

	public override string Author => "Qyriad";

	public override string Description => "Export server-side character to a .plr file";

	public ExportSsc(Main game) : base(game)
	{
	}

	public override void Initialize()
	{
		Commands.ChatCommands.Add(new Command("exportssc", ExportCommand, "exportssc"));
	}

	protected void ExportCommand(CommandArgs arg)
	{
		var player = arg.Player;
		var fileData = new PlayerFileData("./ssc.plr", cloudSave: false);
		fileData.Player = Main.player[0];
		var md = FileMetadata.FromCurrentSettings(FileType.Player);
		fileData.Metadata = md;
		Player.InternalSavePlayerFile(fileData);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
		}
		base.Dispose(disposing);
	}
}
