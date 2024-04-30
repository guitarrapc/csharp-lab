```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,311.1 ns** |    **105.71 ns** |     **5.79 ns** |     **1,307.3 ns** |     **1,317.7 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,557.6 ns |     75.60 ns |     4.14 ns |     1,552.9 ns |     1,560.8 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,708.1 ns |     88.11 ns |     4.83 ns |     1,703.9 ns |     1,713.4 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,669.3 ns |    287.83 ns |    15.78 ns |     2,654.2 ns |     2,685.7 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       216.5 ns |     17.60 ns |     0.96 ns |       215.7 ns |       217.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       286.3 ns |     74.30 ns |     4.07 ns |       283.4 ns |       290.9 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       495.0 ns |     75.50 ns |     4.14 ns |       492.6 ns |       499.8 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,114.7 ns** |  **3,553.71 ns** |   **194.79 ns** | **1,545,963.3 ns** | **1,546,334.5 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,406.4 ns |  2,339.47 ns |   128.23 ns |   614,269.3 ns |   614,523.4 ns |      - |      61 B |
| SHA256Binary    | Byte[1048576]       |   655,933.4 ns | 23,901.29 ns | 1,310.11 ns |   655,130.5 ns |   657,445.2 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,374,613.1 ns | 40,726.60 ns | 2,232.36 ns | 1,372,783.2 ns | 1,377,100.3 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,330.1 ns |    336.16 ns |    18.43 ns |   162,317.9 ns |   162,351.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,544.1 ns |  4,085.96 ns |   223.97 ns |    91,393.0 ns |    91,801.4 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,419.8 ns |  5,676.37 ns |   311.14 ns |    65,084.0 ns |    65,698.3 ns |      - |      40 B |
