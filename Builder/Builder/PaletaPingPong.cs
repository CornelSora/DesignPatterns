using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class PaletaPingPong
    {
        private readonly string brand;
        private readonly string handle;
        private readonly double spinRating;
        private readonly double speedRating;
        private readonly double controlRating;

        private PaletaPingPong(Builder builder)
        {
            this.brand = builder.brand;
            this.handle = builder.handle;
            this.spinRating = builder.spinRating;
            this.speedRating = builder.speedRating;
            this.controlRating = builder.controlRating;
        }

        public override string ToString()
        {
            return string.Format("Pallete with brand: {0}, handle: {1}, spin rating: {2}, speed rating: {3}, control rating: {4}",
                brand, handle, spinRating, speedRating, controlRating);
        }

        public class Builder
        {
            internal string brand;
            internal string handle;
            internal double spinRating;
            internal double speedRating;
            internal double controlRating;

            public Builder(string brand, string handle)
            {
                this.brand = brand;
                this.handle = handle;
            }

            public Builder setSpinRating(double spinRating)
            {
                this.spinRating = spinRating;
                return this;
            }

            public Builder setSpeedRating(double speedRating)
            {
                this.speedRating = speedRating;
                return this;
            }

            public Builder setControlRating(double controlRating)
            {
                this.controlRating = controlRating;
                return this;
            }

            public PaletaPingPong createPingPongPalette() => new PaletaPingPong(this);
        }
    }
}
