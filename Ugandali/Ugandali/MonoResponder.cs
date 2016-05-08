using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using System.Threading;
namespace Ugandali
{
    class MonoResponder : UgandaliMain.IResponder
    {
        Game1 game;
        EventWaitHandle waitHandle = new AutoResetEvent(false);
        public MonoResponder(Game1 game)
        {
            this.game = game;    
        }
        void suspend(TimeSpan timeout)
        {
            waitHandle.WaitOne(timeout);
        }
        void Resume()
        {
            waitHandle.Set();
        }

        public void ChangeBackgroundColor()
        {
            game.BackgroundColor = Color.Red;
            suspend(TimeSpan.FromSeconds(2.0));
            game.BackgroundColor = Color.Green;
        }

    }
}
