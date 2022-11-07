using System;
using Terraria;
using TerrariaApi.Server;
using TShockAPI;

namespace CloudSaves;

/// <summary>
/// The main plugin class should always be decorated with an ApiVersion attribute. The current API version is 1.25.
[ApiVersion(2, 1)]
public class CloudSaves : TerrariaPlugin
{
	public override string Name => "CloudSaves";

	public override Version Version => new Version(0, 1, 0);

	public override string Author => "Qyriad";

	public override string Description => "Conditional server-side characters to emulate cloud saves";

	public CloudSaves(Main game) : base(game)
	{
	}

	public override void Initialize()
	{
		TShock.Log.ConsoleInfo("Initialize()!");
	}
}
