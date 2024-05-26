```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,310.8 ns** |     **83.48 ns** |     **4.58 ns** |     **1,305.6 ns** |     **1,314.2 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,448.9 ns |     71.13 ns |     3.90 ns |     1,445.0 ns |     1,452.8 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,688.3 ns |     10.19 ns |     0.56 ns |     1,687.7 ns |     1,688.7 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,640.9 ns |    153.05 ns |     8.39 ns |     2,634.1 ns |     2,650.3 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       212.3 ns |     24.93 ns |     1.37 ns |       211.1 ns |       213.8 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       286.8 ns |     32.17 ns |     1.76 ns |       284.9 ns |       288.4 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       524.8 ns |      6.68 ns |     0.37 ns |       524.5 ns |       525.2 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,955.9 ns** |  **4,559.67 ns** |   **249.93 ns** | **1,545,720.5 ns** | **1,546,218.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,492.1 ns |  5,428.39 ns |   297.55 ns |   614,287.8 ns |   614,833.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,071.8 ns | 23,621.21 ns | 1,294.76 ns |   655,025.0 ns |   657,519.6 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,452.0 ns | 22,261.59 ns | 1,220.23 ns | 1,372,680.2 ns | 1,374,858.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,318.2 ns | 35,573.53 ns | 1,949.91 ns |   162,161.8 ns |   165,569.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,408.5 ns |  2,041.67 ns |   111.91 ns |    92,331.9 ns |    92,536.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,184.8 ns |  8,786.63 ns |   481.62 ns |    64,905.5 ns |    65,741.0 ns |      - |      40 B |
