﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Financier.Converters
{
    public class MccConverter : IValueConverter
    {
        static MccConverter()
        {
            var tmp = new Dictionary<string, int[]>
            {
                { "Автосервіс", new [] {5511, 5531, 5532, 5533, 7531, 7534, 7535, 7538, 7542} },
                { "Авіаквитки" , new [] { 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3150, 3151, 3152, 3153, 3154, 3155, 3156, 3157, 3158, 3159, 3160, 3161, 3162, 3163, 3164, 3165, 3166, 3167, 3168, 3169, 3170, 3171, 3172, 3173, 3174, 3175, 3176, 3177, 3178, 3179, 3180, 3181, 3182, 3183, 3184, 3185, 3186, 3187, 3188, 3189, 3190, 3191, 3192, 3193, 3194, 3195, 3196, 3197, 3198, 3199, 3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3281, 3282, 3283, 3284, 3285, 3286, 3287, 3288, 3289, 3290, 3291, 3292, 3293, 3294, 3295, 3296, 3297, 3298, 3299, 3301, 4511, 3000, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3250, 3251, 3252, 3253, 3254, 3256, 3257, 3258, 3259, 3260, 3261, 3262, 3263, 3264, 3265, 3266, 3267, 3268, 3270, 3274, 3275, 3276, 3277, 3278, 3279 } },
                { "АЗС", new []{5172, 5541, 5542, 5983 } },
                { "Аптеки",new [] {5912, 5122, 5292, 5295}},
                { "Готелі ", new int[]{ 3700, 3699, 3698, 3697, 3696, 3695, 3694, 3693, 3692, 3691, 3690, 3689, 3688, 3687, 3686, 3685, 3684, 3683, 3682, 3681, 3680, 3679, 3678, 3677, 3676, 3675, 3674, 3673, 3672, 3671, 3670, 3669, 3668, 3667, 3666, 3665, 3664, 3663, 3662, 3661, 3660, 3659, 3658, 3657, 3656, 3655, 3654, 3653, 3652, 3651, 3650, 3649, 3648, 3647, 3646, 3645, 3644, 3643, 3642, 3641, 3640, 3639, 3638, 3637, 3636, 3635, 3634, 3633, 3632, 3631, 3630, 3629, 3628, 3627, 3626, 3625, 3624, 3623, 3622, 3621, 3620, 3619, 3618, 3617, 3616, 3615, 3614, 3613, 3612, 3611, 3610, 3609, 3608, 3607, 3606, 3605, 3604, 3603, 3602, 3601, 3600, 3599, 3598, 3597, 3596, 3595, 3594, 3593, 3592, 3591, 3590, 3589, 3588, 3587, 3586, 3585, 3584, 3583, 3582, 3581, 3580, 3579, 3578, 3577, 3576, 3575, 3574, 3573, 3572, 3571, 3570, 3569, 3568, 3567, 3566, 3565, 3564, 3563, 3562, 3561, 3560, 3559, 3558, 3557, 3556, 3555, 3554, 3553, 3552, 3551, 3550, 3549, 3548, 3547, 3546, 3545, 3544, 3543, 3542, 3541, 3540, 3539, 3538, 3537, 3536, 3535, 3534, 3533, 3532, 3531, 3530, 3529, 3528, 3527, 3526, 3525, 3524, 3523, 3522, 3521, 3520, 3519, 3518, 3517, 3516, 3515, 3514, 3513, 3512, 3511, 3510, 3509, 3508, 3507, 3506, 3505, 3504, 3503, 3502 } },
                { "Взуття",new [] {5139, 5661}},
                { "Все для дому",new [] {5200, 5211, 5231, 5713, 5712, 5719, 5131}},
                { "Duty Free",new [] {5309}},
                { "Дозвілля",new [] {7932, 7933, 7996, 7998, 7999, 5733, 5818, 7841, 7993, 7221, 7395}},
                { "Хімчистки",new [] {7216, 7210, 7211, 7251, 7217}},
                { "Дитячі товари",new [] {5641, 5945}},
                { "Зоомагазини",new [] {0742, 5995}},
                { "Ігри та додатки",new [] {5816, 5817, 5815}},
                { "Кафе та ресторани",new [] {5811, 5812, 5813, 5814}},
                { "Квіти",new [] {5992, 0780, 5261, 5193}},
                { "Кіно та театри",new [] {7829, 7832, 7922}},
                { "Книги", new []{5192, 5942, 5943, 5949, 5970}},
                { "Кондитерські",new [] {5441, 5462}},
                { "Краса та догляд", new []{7230, 7297, 7298, 5977}},
                { "Маркетплейси", new [] {5300, 5964, 5310, 5311, 5331, 5399, 5999 }},
                { "Медзаклади", new [] { 8021, 8062, 8071, 8099, 4119, 8011, 8031, 8041, 8042, 8049, 8050, 8043 }},
                { "Одяг", new [] { 5611, 5931, 5137, 5699, 5691, 5681, 5651, 5621 }},
                { "Продукти", new [] { 5411, 5499, 5451, 5422, 5412, 5921 }},
                { "Спорт та фітнес", new [] { 5655, 5940, 5941, 7911, 7941, 7992, 7997 }},
                { "Таксі", new [] { 4121 }},
                { "Техніка", new [] { 4812, 5722, 5732, 5946 }},
                { "Транспорт", new [] { 4131, 4111, 4112 }},
                { "Доставка", new [] { 7399, 8999 } },
                { "Переказ", new [] { 4829 } },
                { "Комунальні", new [] { 4900 } },
                { "Банкомат", new [] { 6011 } },
                { "Мобільний", new [] { 4814 } },
            };
            MCC = tmp.SelectMany(x => x.Value.Select(y => new KeyValuePair<int, string>(y, x.Key))).ToDictionary(x => x.Key, y => y.Value);
        }

        private static readonly Dictionary<int, string> MCC;


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int mcc = (int)value;
            if (MCC.ContainsKey(mcc))
            {
                  return MCC[mcc];
            }
            return mcc.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private static IEnumerable<int> Range(int from, int to)
        {
            return Enumerable.Range(from, to - from + 1);
        }
    }
}
