using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Component
    {
        protected Component BaseComponent;
        public abstract int ComputePower();
    }

    public class WeaponComponent : Component
    {
        private const int ComponentPower = 5;

        public WeaponComponent(Component component)
        {
            BaseComponent = component;
        }
        public override int ComputePower()
        {
            return BaseComponent.ComputePower() + ComponentPower;
        }
        public override string ToString()
        {
            return BaseComponent.ToString() + " with weapon";
        }
    }

    public class ShieldComponent : Component
    {
        private const int ComponentPower = 3;

        public ShieldComponent(Component component)
        {
            BaseComponent = component;
        }
        public override int ComputePower()
        {
            return BaseComponent.ComputePower() + ComponentPower;
        }
        public override string ToString()
        {
            return BaseComponent.ToString() + " with shield";
        }
    }

    public class Player : Component
    {
        public override int ComputePower()
        {
            return 0;
        }
        public override string ToString()
        {
            return "base player";
        }
    }
}
