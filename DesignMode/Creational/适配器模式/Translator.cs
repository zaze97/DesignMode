
    using System;

    public class Translator: Player
    {
        private OutCenter _outCenter;
        public Translator(string name) : base(name)
        {
            _outCenter = new OutCenter();
            _outCenter.Name = name;
        }

        public override void Attack()
        {
            _outCenter.进攻();
        }

        public override void Defense()
        {
            _outCenter.防守();
        }
    }