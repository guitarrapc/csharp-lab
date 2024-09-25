```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,216.1 ns** |      **24.35 ns** |     **1.33 ns** |     **1,214.6 ns** |     **1,217.0 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,379.1 ns |      36.80 ns |     2.02 ns |     1,376.9 ns |     1,380.9 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,610.0 ns |     137.93 ns |     7.56 ns |     1,602.9 ns |     1,617.9 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,597.7 ns |     239.39 ns |    13.12 ns |     2,589.8 ns |     2,612.9 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       207.9 ns |      27.29 ns |     1.50 ns |       207.0 ns |       209.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       294.9 ns |       6.30 ns |     0.35 ns |       294.5 ns |       295.1 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       511.3 ns |      37.90 ns |     2.08 ns |       510.0 ns |       513.7 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,553,551.9 ns** |     **947.68 ns** |    **51.95 ns** | **1,553,514.3 ns** | **1,553,611.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,593.0 ns |   4,272.65 ns |   234.20 ns |   617,363.4 ns |   617,831.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,863.8 ns |  22,707.83 ns | 1,244.69 ns |   658,567.4 ns |   661,049.4 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,387,942.9 ns | 131,530.43 ns | 7,209.63 ns | 1,381,274.7 ns | 1,395,593.2 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,303.2 ns |   1,184.36 ns |    64.92 ns |   163,248.6 ns |   163,375.0 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,923.9 ns |   2,253.46 ns |   123.52 ns |    91,841.9 ns |    92,066.0 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,984.4 ns |   5,949.26 ns |   326.10 ns |    65,621.9 ns |    66,253.8 ns |      - |      40 B |
