```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,313.2 ns** |      **35.30 ns** |     **1.93 ns** |     **1,311.5 ns** |     **1,315.3 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,494.1 ns |     451.76 ns |    24.76 ns |     1,465.8 ns |     1,511.9 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,734.3 ns |     546.41 ns |    29.95 ns |     1,715.0 ns |     1,768.8 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,696.6 ns |     112.08 ns |     6.14 ns |     2,689.6 ns |     2,701.1 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       206.9 ns |      22.30 ns |     1.22 ns |       205.5 ns |       207.8 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       294.1 ns |      37.17 ns |     2.04 ns |       291.7 ns |       295.3 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       496.9 ns |      37.21 ns |     2.04 ns |       495.3 ns |       499.2 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,844.9 ns** |   **3,696.73 ns** |   **202.63 ns** | **1,546,611.1 ns** | **1,546,970.9 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,964.4 ns |   1,376.34 ns |    75.44 ns |   614,880.0 ns |   615,025.3 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,445.4 ns |  26,733.71 ns | 1,465.36 ns |   655,419.7 ns |   658,123.7 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,379,111.0 ns | 181,368.91 ns | 9,941.44 ns | 1,372,510.0 ns | 1,390,544.9 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,677.7 ns |   6,631.09 ns |   363.47 ns |   162,462.1 ns |   163,097.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,581.1 ns |   3,346.60 ns |   183.44 ns |    91,467.3 ns |    91,792.7 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,491.4 ns |   8,262.86 ns |   452.92 ns |    64,974.1 ns |    65,816.8 ns |      - |      40 B |
