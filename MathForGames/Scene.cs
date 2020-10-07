using System;
using System.Collections.Generic;
using System.Text;

namespace MathForGames
{
    class Scene
    {
        private Entity[] _entities;

        public Scene()
        {
            _entities = new Entity[0];
        }

        public void AddEntity(Entity entity)
        {
            Entity[] appendedArray = new Entity[_entities.Length + 1];

            for(int i = 0; i < appendedArray.Length; i++)
            {
                if(i < _entities.Length)
                {
                    appendedArray[i] = _entities[i];
                }
                else
                {
                    appendedArray[i] = entity;
                }
            }

            _entities = appendedArray;
        }

        public void Start()
        {

        }

        public void Update()
        {

        }

        public void Draw()
        {

        }

        public void End()
        {

        }
    }
}
