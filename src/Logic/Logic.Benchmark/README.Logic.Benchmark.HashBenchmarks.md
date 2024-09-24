```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,246.9 ns** |     **142.67 ns** |     **7.82 ns** |     **1,240.0 ns** |     **1,255.4 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,379.0 ns |     249.23 ns |    13.66 ns |     1,366.7 ns |     1,393.7 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,623.8 ns |      96.35 ns |     5.28 ns |     1,617.8 ns |     1,627.6 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,587.3 ns |     283.54 ns |    15.54 ns |     2,569.4 ns |     2,596.7 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       255.3 ns |      23.17 ns |     1.27 ns |       254.0 ns |       256.5 ns | 0.0067 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       324.9 ns |      24.92 ns |     1.37 ns |       323.4 ns |       326.1 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       487.9 ns |      70.99 ns |     3.89 ns |       483.8 ns |       491.5 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,553,233.8 ns** |   **1,775.19 ns** |    **97.30 ns** | **1,553,153.8 ns** | **1,553,342.1 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   618,768.0 ns |  33,559.46 ns | 1,839.51 ns |   617,687.1 ns |   620,892.0 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   660,203.0 ns |  13,463.18 ns |   737.96 ns |   659,355.5 ns |   660,704.0 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,385,032.8 ns | 118,789.08 ns | 6,511.23 ns | 1,380,232.6 ns | 1,392,444.4 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,864.2 ns |  13,913.03 ns |   762.62 ns |   163,076.9 ns |   164,599.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,144.7 ns |   3,551.14 ns |   194.65 ns |    91,919.9 ns |    92,257.5 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    66,042.2 ns |   3,304.35 ns |   181.12 ns |    65,840.0 ns |    66,189.5 ns |      - |      40 B |
