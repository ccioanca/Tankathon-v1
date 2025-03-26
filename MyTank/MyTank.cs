using Tankathon.API;
using GD = Godot.GD;

namespace Tankathon.MyTank;
public class MyTank : ITank
{
    //Logic to do at initialization
    public void Setup(ITankStats stats)
	{
		//Prints a debug message
		GD.Print("My tank - Tank Setup");
		stats.name = "My Tank";
	}

	//Logic to do every frame
	public void Do(IActions actions, IScoreboard scoreboard)
	{
		//Your Tank Brain logic starts here.
		actions.MoveForward();
    }

}
