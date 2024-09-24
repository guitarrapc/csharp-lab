```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,217.2 ns** |     **132.24 ns** |      **7.25 ns** |     **1,209.4 ns** |     **1,223.8 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,352.3 ns |     161.05 ns |      8.83 ns |     1,342.2 ns |     1,358.4 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,595.3 ns |     125.98 ns |      6.91 ns |     1,587.4 ns |     1,600.2 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,550.1 ns |     106.86 ns |      5.86 ns |     2,545.0 ns |     2,556.5 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       215.0 ns |      70.64 ns |      3.87 ns |       210.9 ns |       218.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       294.2 ns |     200.55 ns |     10.99 ns |       286.6 ns |       306.8 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       496.4 ns |      47.35 ns |      2.60 ns |       493.5 ns |       498.6 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,548,441.6 ns** | **119,062.56 ns** |  **6,526.22 ns** | **1,541,385.2 ns** | **1,554,260.3 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,849.6 ns |   2,009.04 ns |    110.12 ns |   617,746.1 ns |   617,965.3 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,893.3 ns |  23,340.13 ns |  1,279.35 ns |   658,575.5 ns |   661,130.4 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,370,852.3 ns | 254,666.14 ns | 13,959.11 ns | 1,358,522.6 ns | 1,386,008.3 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   161,782.9 ns |  13,353.24 ns |    731.94 ns |   161,149.4 ns |   162,584.2 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,089.4 ns |   4,372.04 ns |    239.65 ns |    91,892.5 ns |    92,356.2 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,549.4 ns |   1,707.89 ns |     93.62 ns |    65,473.7 ns |    65,654.1 ns |      - |      40 B |
