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

        public bool RemoveActor(int index)
        {
            if(index < 0 || index >= _entities.Length)
            {
                return false;
            }

            bool entityRemoved = false;

            Entity[] newArray = new Entity[_entities.Length - 1];
            int j = 0;
            for(int i = 0; i < _entities.Length; i++)
            {
                if(i != index)
                {
                    newArray[j] = _entities[i];
                    j++;
                }
                else
                {
                    entityRemoved = true;
                }
            }

            _entities = newArray;
            return entityRemoved;
        }

        public bool RemoveEntity(Entity entity)
        {
            if(entity == null)
            {
                return false;
            }

            bool entityRemoved = false;
            Entity[] newArray = new Entity[_entities.Length - 1];
            int j = 0;
            for (int i = 0; i < _entities.Length; i++)
            {
                if (entity != _entities[i])
                {
                    newArray[j] = _entities[i];
                    j++;
                }
                else
                {
                    entityRemoved = true;
                }
            }

            _entities = newArray;
            return entityRemoved;
        }

        public void Start()
        {
            for (int i = 0; i < _entities.Length; i++)
            {
                _entities[i].Start();
            }
        }

        public void Update()
        {
            for (int i = 0; i < _entities.Length; i++)
            {
                _entities[i].Update();
            }
        }

        public void Draw()
        {
            for (int i = 0; i < _entities.Length; i++)
            {
                _entities[i].Draw();
            }
        }

        public void End()
        {
            for (int i = 0; i < _entities.Length; i++)
            {
                _entities[i].End();
            }
        }
    }
}
