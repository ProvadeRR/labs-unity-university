namespace lab1.task1
{
    class Triangle
    {

        private double _cathenusFirst;
        private double _cathenusSecond;

        public Triangle(double firstCathenus, double secondCathenus)
        {
            this._cathenusFirst = firstCathenus;
            this._cathenusSecond = secondCathenus;
        }

        public double getCathenusFirst()
        {
            return this._cathenusFirst;
        }

        public double getCathenusSecond()
        {
            return this._cathenusSecond;
        }


    }
}
