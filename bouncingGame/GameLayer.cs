using System;
using System.Collections.Generic;
using CocosSharp;
using Xamarin.Forms;

namespace bouncingGame
{
	public class GameLayer : CCLayer
	{
		CCSprite paddleSprite;
		CCLayer layer = new CCLayerColor(CCColor4B.Black);

		public GameLayer()
		{


			// "paddle" refers to the paddle.png image
			paddleSprite = new CCSprite("paddle");
			paddleSprite.PositionX = 100;
			paddleSprite.PositionY = 100;
			AddChild(paddleSprite);
		}
		protected override void AddedToScene()
		{
			base.AddedToScene();
			// Use the bounds to layout the positioning of our drawable assets
			CCRect bounds = VisibleBoundsWorldspace;
			// Register for touch events
			var touchListener = new CCEventListenerTouchAllAtOnce();
			touchListener.OnTouchesEnded = OnTouchesEnded;
			AddEventListener(touchListener, this);
		}
		void OnTouchesEnded(List<CCTouch> touches, CCEvent touchEvent)
		{
			if (touches.Count > 0)
			{
				// Perform touch handling here
			}
		}

		public static implicit operator Page(GameLayer v)
		{
			throw new NotImplementedException();
		}
	}
}
