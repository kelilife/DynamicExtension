﻿namespace KeLi.DynamicExtension.DB
{
    public class Element
    {
        public Element(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}