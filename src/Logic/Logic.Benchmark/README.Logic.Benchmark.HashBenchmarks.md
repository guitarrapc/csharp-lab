```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,374.7 ns** |     **129.33 ns** |      **7.09 ns** |     **1,367.1 ns** |     **1,381.1 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,554.3 ns |      37.90 ns |      2.08 ns |     1,552.0 ns |     1,556.1 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,789.1 ns |      70.26 ns |      3.85 ns |     1,786.3 ns |     1,793.5 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,786.8 ns |     918.51 ns |     50.35 ns |     2,739.3 ns |     2,839.6 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       191.3 ns |      61.02 ns |      3.34 ns |       188.1 ns |       194.8 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       313.8 ns |      10.33 ns |      0.57 ns |       313.1 ns |       314.1 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       466.8 ns |      61.46 ns |      3.37 ns |       463.0 ns |       469.2 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,332.7 ns |      90.27 ns |      4.95 ns |     1,327.1 ns |     1,336.3 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,565.2 ns |     149.63 ns |      8.20 ns |     1,560.2 ns |     1,574.7 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,782.5 ns |     209.47 ns |     11.48 ns |     1,769.5 ns |     1,791.2 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,786.8 ns |     418.86 ns |     22.96 ns |     2,765.9 ns |     2,811.4 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       189.7 ns |      43.36 ns |      2.38 ns |       187.3 ns |       192.0 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       264.2 ns |      20.02 ns |      1.10 ns |       263.1 ns |       265.3 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       503.4 ns |     101.56 ns |      5.57 ns |       498.6 ns |       509.5 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,554,215.6 ns** |   **9,038.79 ns** |    **495.45 ns** | **1,553,862.4 ns** | **1,554,782.0 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,903.4 ns |   2,468.10 ns |    135.28 ns |   617,789.2 ns |   618,052.8 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,651.0 ns |  27,045.44 ns |  1,482.45 ns |   658,665.2 ns |   661,355.9 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,430,002.7 ns | 339,378.95 ns | 18,602.51 ns | 1,408,916.1 ns | 1,444,091.6 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,730.0 ns |  11,747.32 ns |    643.91 ns |   163,113.3 ns |   164,398.1 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    91,984.8 ns |   1,072.24 ns |     58.77 ns |    91,918.4 ns |    92,030.1 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,661.8 ns |   2,683.87 ns |    147.11 ns |    65,523.7 ns |    65,816.5 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,554,346.3 ns |  12,050.19 ns |    660.51 ns | 1,553,688.1 ns | 1,555,009.1 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,628.5 ns |   1,508.62 ns |     82.69 ns |   617,549.0 ns |   617,714.0 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   658,694.5 ns |   3,262.55 ns |    178.83 ns |   658,511.4 ns |   658,868.7 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,380,986.4 ns |  29,862.45 ns |  1,636.86 ns | 1,379,676.7 ns | 1,382,821.4 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,370.6 ns |   7,771.91 ns |    426.00 ns |   163,089.9 ns |   163,860.7 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    92,230.2 ns |   8,165.27 ns |    447.57 ns |    91,842.5 ns |    92,720.0 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    34,077.8 ns |   4,346.06 ns |    238.22 ns |    33,807.7 ns |    34,257.9 ns |      - |      40 B |
