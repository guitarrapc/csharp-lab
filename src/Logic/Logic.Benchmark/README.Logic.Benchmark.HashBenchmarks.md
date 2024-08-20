```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,324.7 ns** |      **18.38 ns** |      **1.01 ns** |     **1,323.6 ns** |     **1,325.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,472.4 ns |     226.44 ns |     12.41 ns |     1,464.1 ns |     1,486.7 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,694.2 ns |      41.23 ns |      2.26 ns |     1,692.6 ns |     1,696.7 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,677.5 ns |     433.15 ns |     23.74 ns |     2,657.9 ns |     2,703.9 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       201.0 ns |      12.31 ns |      0.67 ns |       200.4 ns |       201.7 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       285.4 ns |      28.70 ns |      1.57 ns |       283.6 ns |       286.7 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       472.7 ns |      83.87 ns |      4.60 ns |       467.7 ns |       476.7 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,393.1 ns** |   **5,601.12 ns** |    **307.02 ns** | **1,546,089.1 ns** | **1,546,703.1 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,844.3 ns |   2,576.06 ns |    141.20 ns |   614,682.7 ns |   614,943.9 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   658,195.7 ns |  66,220.65 ns |  3,629.78 ns |   655,606.6 ns |   662,344.7 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,379,447.4 ns | 197,975.43 ns | 10,851.70 ns | 1,372,833.5 ns | 1,391,971.2 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,173.1 ns |  22,743.43 ns |  1,246.64 ns |   162,444.6 ns |   164,612.6 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,736.5 ns |   5,323.39 ns |    291.79 ns |    91,520.7 ns |    92,068.5 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,950.8 ns |   5,729.84 ns |    314.07 ns |    65,679.6 ns |    66,294.9 ns |      - |      40 B |
