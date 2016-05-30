using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTDD
{
    public class Calculator
    {
        public event EventHandler CalculatedEvent;

        public Calculator()
        {
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public float Divide(int dividend, int divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException();
            float result = (float)dividend / divisor;
            OnCalculated();
            return result;
        }

        public async Task<float> DivideAsync(double dividend, double divisor)
        {
            if (divisor == 0) throw new DivideByZeroException();

            await Task.Delay(millisecondsDelay: 1000)
                      .ConfigureAwait(continueOnCapturedContext: false);

            return (float)dividend / (float)divisor;
        }

        protected virtual void OnCalculated()
        {
            var handler = CalculatedEvent;
            if (handler != null) handler(this, EventArgs.Empty);
        }
    }
}
