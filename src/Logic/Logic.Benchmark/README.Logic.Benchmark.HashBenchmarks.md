```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,322.6 ns** |      **81.83 ns** |     **4.49 ns** |     **1,319.3 ns** |     **1,327.7 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,476.6 ns |     123.21 ns |     6.75 ns |     1,468.8 ns |     1,481.2 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,715.8 ns |      54.84 ns |     3.01 ns |     1,712.3 ns |     1,717.7 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,711.4 ns |     160.32 ns |     8.79 ns |     2,703.1 ns |     2,720.6 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       205.5 ns |      23.04 ns |     1.26 ns |       204.2 ns |       206.7 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       291.9 ns |       4.17 ns |     0.23 ns |       291.6 ns |       292.0 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       506.1 ns |       2.23 ns |     0.12 ns |       505.9 ns |       506.2 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,094.4 ns** |   **4,823.33 ns** |   **264.38 ns** | **1,545,843.0 ns** | **1,546,370.1 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,615.4 ns |   3,985.65 ns |   218.47 ns |   614,440.7 ns |   614,860.4 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,006.6 ns |  19,683.92 ns | 1,078.94 ns |   655,079.6 ns |   657,191.0 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,378,692.1 ns | 101,897.01 ns | 5,585.32 ns | 1,374,872.5 ns | 1,385,102.4 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,631.9 ns |   5,586.48 ns |   306.21 ns |   162,278.4 ns |   162,817.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,466.5 ns |   1,190.97 ns |    65.28 ns |    91,394.0 ns |    91,520.6 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,534.3 ns |   5,318.13 ns |   291.50 ns |    65,273.6 ns |    65,849.1 ns |      - |      40 B |
