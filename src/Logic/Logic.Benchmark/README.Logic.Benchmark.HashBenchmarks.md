```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,313.7 ns** |     **19.64 ns** |     **1.08 ns** |     **1,312.5 ns** |     **1,314.4 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,455.7 ns |     41.71 ns |     2.29 ns |     1,453.8 ns |     1,458.3 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,684.6 ns |     38.97 ns |     2.14 ns |     1,682.4 ns |     1,686.7 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,651.7 ns |    320.82 ns |    17.59 ns |     2,640.6 ns |     2,672.0 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       194.8 ns |     13.14 ns |     0.72 ns |       194.3 ns |       195.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       271.6 ns |      3.21 ns |     0.18 ns |       271.4 ns |       271.8 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       494.5 ns |     21.32 ns |     1.17 ns |       493.2 ns |       495.4 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,075.9 ns** |  **4,425.08 ns** |   **242.55 ns** | **1,545,809.1 ns** | **1,546,283.1 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,181.3 ns |  1,144.67 ns |    62.74 ns |   614,141.2 ns |   614,253.6 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,161.3 ns | 23,488.78 ns | 1,287.50 ns |   654,891.6 ns |   657,465.9 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,179.6 ns | 23,045.47 ns | 1,263.20 ns | 1,372,000.0 ns | 1,374,512.4 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,344.3 ns |  5,827.17 ns |   319.41 ns |   162,145.1 ns |   162,712.7 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,349.7 ns |    320.59 ns |    17.57 ns |    91,329.5 ns |    91,361.7 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    33,765.3 ns |  8,140.59 ns |   446.21 ns |    33,502.2 ns |    34,280.5 ns |      - |      40 B |
