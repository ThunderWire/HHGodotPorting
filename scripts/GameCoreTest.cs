using Godot;
using System;
using System.Collections.Generic;
using GDK.XGamingRuntime;
using Microsoft.GDK.Tests;

public partial class GameCoreTest : Node
{
	public override void _Ready()
	{
		GdkTestHelper.Initialize("GameCoreTest._Ready");

		XNetworkingQueryPreferredLocalUdpMultiplayerPort();
		XNetworkingGetConnectivityHint();
	}
	
	public void XNetworkingQueryPreferredLocalUdpMultiplayerPort()
	{
		UInt16 preferredLocalUdpMultiplayerPort = 0;
		int hResult = SDK.XNetworkingQueryPreferredLocalUdpMultiplayerPort(out preferredLocalUdpMultiplayerPort);
		
		if (HR.SUCCEEDED(hResult))
		{
			GD.Print($"Call to XNetworkingQueryPreferredLocalUdpMultiplayerPort() returned: {preferredLocalUdpMultiplayerPort}");
			return;
		}

		GD.PrintErr($"Call to XNetworkingQueryPreferredLocalUdpMultiplayerPort() failed! (hResult=0x{hResult:X8} '{HR.NameOf(hResult)}')");
	}
	
	
	public void XNetworkingGetConnectivityHint()
	{
		XNetworkingConnectivityHint connectivityHint;
		int hResult = SDK.XNetworkingGetConnectivityHint(out connectivityHint);
		
		if (HR.SUCCEEDED(hResult))
		{
			GD.Print($"Call to XNetworkingGetConnectivityHint() returned: {connectivityHint}");
			return;
		}
		
		GD.PrintErr($"Call to XNetworkingGetConnectivityHint() failed! (hResult=0x{hResult:X8} '{HR.NameOf(hResult)}')");
	}
}
