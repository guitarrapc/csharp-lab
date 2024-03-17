```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,261.3 ns** |     **352.00 ns** |     **19.29 ns** |     **1,244.9 ns** |     **1,282.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,407.8 ns |     310.86 ns |     17.04 ns |     1,391.5 ns |     1,425.5 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,659.8 ns |     546.80 ns |     29.97 ns |     1,637.5 ns |     1,693.9 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,585.0 ns |     806.74 ns |     44.22 ns |     2,534.1 ns |     2,613.4 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       206.6 ns |      21.80 ns |      1.19 ns |       205.4 ns |       207.8 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       266.9 ns |      57.25 ns |      3.14 ns |       263.3 ns |       269.1 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       462.5 ns |      24.94 ns |      1.37 ns |       461.3 ns |       464.0 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,510,879.9 ns** | **274,750.33 ns** | **15,059.99 ns** | **1,493,602.0 ns** | **1,521,224.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   590,688.8 ns |  84,742.93 ns |  4,645.05 ns |   585,813.7 ns |   595,063.2 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   640,262.8 ns | 259,187.19 ns | 14,206.92 ns |   630,211.1 ns |   656,516.3 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,332,365.2 ns | 275,386.62 ns | 15,094.87 ns | 1,316,643.7 ns | 1,346,743.7 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   160,850.6 ns |  38,038.54 ns |  2,085.02 ns |   158,462.1 ns |   162,306.8 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    90,803.6 ns |  11,277.89 ns |    618.18 ns |    90,093.5 ns |    91,221.4 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    64,909.2 ns |     917.64 ns |     50.30 ns |    64,852.4 ns |    64,948.0 ns |      - |      40 B |
