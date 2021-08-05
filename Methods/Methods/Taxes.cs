using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Taxes
    {
        public int Texas(int income)
        {
            // Texas has no state income tax
            int stateTax = 0;
            int incomeAfterTax = income - (income * stateTax);
            return incomeAfterTax;
        }

        public int Colorado(int income)
        {
            // Colorado has a flat income tax of 4.5%
            float stateTax = 0.0455f;
            int incomeAfterTax = income - Convert.ToInt32((income * stateTax));
            return incomeAfterTax;
        }

        public int California(int income)
        {
            int totalStateTax = 0;
            int incomeAfterTax = 0;
            // California has a variable tax rate
            // Tax Bracket 1
            if (income <= 8544)
            {
                incomeAfterTax = income - (income / 100);
                return incomeAfterTax;
            }
            // Tax Bracket 2
            if (income > 8544 && income <= 20255)
            {
                totalStateTax = Convert.ToInt32((8544 * .01) + ((income - 8544) * .02));
                incomeAfterTax = income - totalStateTax;
                return incomeAfterTax;
            }
            // Tax Bracket 3
            if (income > 20255 && income <= 31969)
            {
                totalStateTax = Convert.ToInt32((8544 * .01) + ((20255 - 8544) * .02) + ((income - 20255) * .04));
                incomeAfterTax = income - totalStateTax;
                return incomeAfterTax;
            }
            // Tax Bracket 4
            if (income > 31969 && income <= 44378)
            {
                totalStateTax = Convert.ToInt32((8544 * .01) + ((20255 - 8544) * .02) + ((31969 - 20255) * .04) + ((income - 31969) * .06));
                incomeAfterTax = income - totalStateTax;
                return incomeAfterTax;
            }
            // Tax Bracket 5
            if (income > 44378 && income <= 56085)
            {
                totalStateTax = Convert.ToInt32((8544 * .01) + ((20255 - 8544) * .02) + ((31969 - 20255) * .04) + ((44378 - 31969) * .06) + ((income - 44378) * .08));
                incomeAfterTax = income - totalStateTax;
                return incomeAfterTax;
            }
            // Tax Bracket 6
            if (income > 56085 && income <= 286492)
            {
                totalStateTax = Convert.ToInt32((8544 * .01) + ((20255 - 8544) * .02) + ((31969 - 20255) * .04) + ((44378 - 31969) * .06) + ((56085 - 44378) * .08) + ((income - 56085) * .093));
                incomeAfterTax = income - totalStateTax;
                return incomeAfterTax;
            }
            // Tax Bracket 7
            if (income > 286492 && income <= 343788)
            {
                totalStateTax = Convert.ToInt32((8544 * .01) + ((20255 - 8544) * .02) + ((31969 - 20255) * .04) + ((44378 - 31969) * .06) + ((56085 - 44378) * .08) + ((286492 - 56085) * .093) + ((income - 286492) * .103));
                incomeAfterTax = income - totalStateTax;
                return incomeAfterTax;
            }
            // Tax Bracket 8
            if (income > 343788 && income <= 572980)
            {
                totalStateTax = Convert.ToInt32((8544 * .01) + ((20255 - 8544) * .02) + ((31969 - 20255) * .04) + ((44378 - 31969) * .06) + ((56085 - 44378) * .08) + ((286492 - 56085) * .093) + ((343788 - 286492) * .103) + ((income - 343788) * .113));
                incomeAfterTax = income - totalStateTax;
                return incomeAfterTax;
            }
            // Tax Bracket 9
            if (income > 572980 && income <= 999999)
            {
                totalStateTax = Convert.ToInt32((8544 * .01) + ((20255 - 8544) * .02) + ((31969 - 20255) * .04) + ((44378 - 31969) * .06) + ((56085 - 44378) * .08) + ((286492 - 56085) * .093) + ((343788 - 286492) * .103) + ((572980 - 343788) * .113) + ((income - 572980) * .123));
                incomeAfterTax = income - totalStateTax;
                return incomeAfterTax;
            }
            // Tax Bracket 10
            if (income > 999999)
            {
                totalStateTax = Convert.ToInt32((8544 * .01) + ((20255 - 8544) * .02) + ((31969 - 20255) * .04) + ((44378 - 31969) * .06) + ((56085 - 44378) * .08) + ((286492 - 56085) * .093) + ((343788 - 286492) * .103) + ((572980 - 343788) * .113) + ((999999 - 572980) * .123) + ((income - 999999) * .133));
                incomeAfterTax = income - totalStateTax;
                return incomeAfterTax;
            }
            else
            {
                return 0;
            }
        }


    }

}
