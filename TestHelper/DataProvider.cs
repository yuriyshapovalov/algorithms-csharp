namespace Algorithms.Tests.Helper
{
    public class DataProvider
    {
        private static DataProvider _instance;
        private static object syncObj = new object();

        private DataProvider() { }

        public static DataProvider GetDataProvider()
        {
            if (_instance == null)
            {
                lock (syncObj)
                {
                    if (_instance == null)
                    {
                        _instance = new DataProvider();
                    }
                }
            }
            return _instance;
        }

        public int[] GetRandomData1K()
        {
            int[] data = 
            {
                542,  697,  593,  523,  521,  605,  449,  511,   44,  539,  652,  258,   64,  518,
                368,  604,  166,  801,  899,  551,  973,  352,  679,  933,  367,    8,   72,  106,
                773,  163,   38,  993,  996,  832,  649,  547,  462,  887,   60,  668,  917,  465,
                701,  546,  126,  325,   46,  901,  220,  964,  415,  567,  870,  168,  482,  451,
                401,  372,  170,  314,  128,  391,  881,  359,  583,  470,  322,  734,  228,   91,
                 22,  879,  886,  706,  269,  441,  909,  981,  787,  234,  910,   69,  263,  675,
                866,  982,    2,  296,   47,  304,  869,  351,  947,  908,  904,  466,  779,  707,
                396,  254,  390,  284,  277,  232,  264,  317,  383,  148,  219,  847,  912,   57,
                865,  834,  687,   90,  721,   19,  661,  202,  177,  563,  732,  922,  515,  915,
                650,  874,  747,  686,  722,  662,  994,  851,  709,   55,  803,  477,  338,  301,
                428,  363,   12,  890,  419,  963,  116,   88,  953,  217,  431,  597,  809,  408,
                789,  193,  541,  937,  222,  587,  711,   53,  949,  384,  299,  475,  764,  414,
                946,  221,  607,  928,   16,  129,  486,  265,  817,  407,   25,  830,   36,  698,
                742,  437,  840,  997,  244,  273,  198,  574,  342,  501,  183,  485,   98,  302,
                476,   37,   39,  298,  285,  247,  923,  242,  140,  392,  885,  424,  253,  767,
                103,  659,  995,  151,  634,   76,  294,  608,  592,   28,  978,  843,  319,  601,
                308,  160,  274,  907,  796,  353,  738,  502,   80,   79,  145,  961,  856,  989,
                167,  318,  164,  357,   81,  416,  238,  804,  664,  959,  765,  880,   26,  676,
                203,  573,  309,  104,  522,  737,  585,  621,  864,  426,   67,  772,  439,  633,
                499,  806,  744,  777,   10,  497,  250,  682,  896,  944,  122,  252,  578,  340,
                669,  891,  176,  493,  374,  507,  595,  549,  596,  341,  613,  854,   62,  895,
                868,  335,  235,   50,  694,  674,  639,  625,  490,  602,  935,  179,  526,  480,
                355,  760,  362,   73,  212,  943,  897,  270,  225,  343,  310,  100,  708,  591,
                919,   32,  483,  313,  584,  236,   43,  945,  727,  704,  169,  259,  138,  582,
                430,  410,  984,   30,  821,   17,  655,  580,  916,  423,  371,  631,  660,  758,
                586,   23,  987,  743,  712,  564,  561,  400,  579,  813,  810,  248,  900,  839,
                 34,  139,  429,  207,  861,  802,  939,  149,  716,  520,  751,  245,  572,  295,
                962,   58,  154,  967,  750,  680,  239,  559,  642,  306,  425,  575,  730,  562,
                952,  617,  628,  347,  998,  927,  469,  914,  178,  960,  814,  199,  119,  243,
                 59,  385,  131,  752,  783,  903,  381,  731,  321,  805,  725,  951,  957,  820,
                550,  214,  696,  276,  594,  266,  598,  671,   84,  626,  576,  966,  657,  375,
                404,  771,  366,  117,  842,   45,  791,  699,  286,  405,  114,  420,    1,  491,
                455,  975,  159,  974,  271,  201,  290,   42,  136,  798,  395,  828,  267,  877,
                516,  636,  336,  365,  251,  705,  615,  246,  231,   40,  223,  753,  174,  514,
                249,  422,   99,  685,  932,  532,  837,  278,  182,  307,  312,  740,  473,  370,
                118,  645,   74,  337,  283,  124,  194,  825,  293,  590,  624,  759,  134,  958,
                102,  229,  911,  929,  175,  838,  413,  393,  436,  528,  619,  350,  913,  720,
                496,   93,  611,  538,  691,  121,  818,  348,   94,  906,  609,   35,  488,   61,
                638,  211,  882,  386,  326,  206,  292,  172,  440,  349,  157,  610,  356,  112,
                589,  113,  600,  795,  672,   75,  776,  332,  768,  565,  354,  210,  402,  552,
                846,  535,  788,  510,  807,  142,  781,  855,  204,    6,  941,  378,  566,  690,
                988,  504,    3,  397,  555,  558,  173,  780,  632,  556,  498,  833,  884,  467,
                388,  667,  924,  736,  543,  146,  983,  133,  954,    5,  143,  599,  548,  815,
                255,  450,  330,  976,  654,  823,  715,  291,  315,  161,  560,  748,  756,  135,
                389,  683,  452,  770,  876,  158,  570,  525,   31,  824,  421,   51,  433,  446,
                329,  568,  257,  785,  808,  755,  829,   87,  418,  406,  417,  965,  339,  460,
                849,  464,  728,  196,   13,  622,  125,  930,  503,  479,   52,  688,  656,  289,
                331,  710,  150,  926,  623,  127,  852,  644,  871,  345,  540,  213,  489,  300,
                101,  387,  327,  534,  377,  782,  784,  640,  991,   77,  268,   21,  230,  863,
                990,  380,  281,  794,  379,  612,  224,  192,  445,  692,  726,  200,  240,  209,
                774,  120,  677,  324,    9,  311,   29,  689,  663,  513,  695,  505,  702,  187,
                411,  826,  581,  635,  233,  272,   78,  970,  557,  718,   54,  905,  999,  481,
                155,  766,  536,  719,    7,  797,  985,  509,  641,  323,  360,  835,  461,  216,
                434,  647,  651,  517,   95,  427,   82,  845,  893,  827,  185,  162,  361,  569,
                792,  678,  533,  346,  191,  681,  443,  955,  778,  279,  670,  186,  107,  606,
                741,  189,  188,  492,  836,  110,  288,  888,  790,  373,  334,   63,  109,  205,
                 18,  735,  979,  800,  629,  618,   14,   83,  305,  786,  156,  137,  403,  394,
                859,   11,  500,  819,  358,  745,  409,  260,  603,  577,  992,  399,  529,  447,
                544,  614,  261,  237,  986,  762,  459,  506,  320,  658,  484,  968,  862,  925,
                875,   20,  241,  889,  524,  878,   86,  333,   41,  749,  763,  147,  275,  184,
                948,  494,  700,  653,  215,  457,  643,  456,   56,  554,  303,  969,  132,  938,
                816,  280,  724,   92,  822,  171,  545,  616,   49,   48,  287,  468,   85, 1000,
                769,  208,   70,  850,   68,  873,  226,   65,  144,  620,  841,  438,  860,  799,
                123,  453,  115,  920,   66,  588,  487,  761,  227,  853,  693,  218,  398,  811,
                902,  883,  454,  831,  152,  153,  666,   27,  754,  108,  316,  256,  474,  934,
                141,   24,  527,  637,  956,  713,  364,  950,  980,  723,  673,  508,   89,  530,
                 96,  105,  867,  972,  472,  435,    4,  892,  921,  746,  512,  844,  369,  627,
                282,  757,  942,  442,  262,  444,  537,  918,  190,  703,  382,  729,  872,   71,
                531,  165,  977,  898,  848,  553,  646,  328,  376,  197,  793,  180,  936,  130,
                195,  344,   15,  630,  297,  733,  857,  717,  648,  665,  940,  181,  432,  478,
                471,  858,  571,  458,  448,   97,  111,  775,  894,  739,  684,  714,  495,  412,
                 33,  463,  971,  812,  931,  519   
            };
            return data;
        }

        public int[] GetEmptyIntegerArray()
        {
            int[] data = { };
            return data;
        }

        public int[] GetOneElementIntegerArray()
        {
            int[] data = { 1 };
            return data;
        }

    }
}