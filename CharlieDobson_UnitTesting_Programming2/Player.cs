using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    public class Player
    {
        public int MaxHealth { get; private set; }
        public int CurrentHealth { get; private set; }

        public int X { get; private set; }
        public int Y { get; private set; }

        public Player(int maxHealth, int startX, int startY)
        {
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
            X = startX;
            Y = startY;
        }

        public void TakeDamage(int amount)
        {
            CurrentHealth -= amount;
            if (CurrentHealth < 0)
            {
                CurrentHealth = 0;
            }
        }

        public void Heal(int amount)
        {
            CurrentHealth += amount;
            if (CurrentHealth > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
        }

        public void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }
    }

