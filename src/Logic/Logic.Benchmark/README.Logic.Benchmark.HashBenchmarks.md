```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,337.0 ns** |     **102.74 ns** |     **5.63 ns** |     **1,332.8 ns** |     **1,343.4 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,461.8 ns |     131.35 ns |     7.20 ns |     1,456.6 ns |     1,470.0 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,688.1 ns |      68.42 ns |     3.75 ns |     1,685.9 ns |     1,692.4 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,616.2 ns |     114.50 ns |     6.28 ns |     2,609.5 ns |     2,622.0 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       199.7 ns |       3.95 ns |     0.22 ns |       199.4 ns |       199.9 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       283.3 ns |      20.73 ns |     1.14 ns |       282.3 ns |       284.5 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       495.9 ns |      19.47 ns |     1.07 ns |       495.1 ns |       497.1 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,179.6 ns** |   **2,453.48 ns** |   **134.48 ns** | **1,545,041.3 ns** | **1,545,310.0 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,209.1 ns |   1,672.96 ns |    91.70 ns |   614,125.2 ns |   614,307.0 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,641.1 ns |  17,898.71 ns |   981.09 ns |   654,727.3 ns |   656,677.9 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,376,594.0 ns | 110,743.46 ns | 6,070.22 ns | 1,373,051.9 ns | 1,383,603.2 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,252.3 ns |   1,740.29 ns |    95.39 ns |   162,194.7 ns |   162,362.4 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,438.7 ns |     959.08 ns |    52.57 ns |    91,392.2 ns |    91,495.7 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,510.5 ns |   5,101.82 ns |   279.65 ns |    65,345.0 ns |    65,833.3 ns |      - |      40 B |
