using System;
namespace CharacterCreationTest
{
    public class Entity
    {
        private string texture;
        private int hp;
        public string Texture { get { return this.texture; } }
        public int HP { get { return this.hp; } set { this.hp = value; } }

        public Entity(string texture, int hp)
        {
            this.texture = texture;
            this.hp = hp;
        }

        public void TakeDamage(int damage)
        {
            this.hp = this.hp - damage;
            if (CheckIfDead())
            {
                Die();
            }
        }

        private bool CheckIfDead()
        {
            if(this.hp <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Die()
        {
            //Erase entities here
        }
    }
}
