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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,323.0 ns** |     **187.73 ns** |    **10.29 ns** |     **1,316.4 ns** |     **1,334.9 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,458.6 ns |     217.63 ns |    11.93 ns |     1,448.2 ns |     1,471.7 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,699.4 ns |      89.41 ns |     4.90 ns |     1,695.5 ns |     1,704.9 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,675.9 ns |     222.34 ns |    12.19 ns |     2,666.0 ns |     2,689.5 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       203.0 ns |       9.79 ns |     0.54 ns |       202.5 ns |       203.5 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       310.1 ns |      24.50 ns |     1.34 ns |       308.6 ns |       311.1 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       486.9 ns |      42.57 ns |     2.33 ns |       484.8 ns |       489.4 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,233.4 ns** |  **25,734.01 ns** | **1,410.57 ns** | **1,545,382.5 ns** | **1,547,861.6 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   615,769.1 ns |  53,916.06 ns | 2,955.32 ns |   614,053.5 ns |   619,181.6 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,757.0 ns |  54,627.87 ns | 2,994.34 ns |   654,998.3 ns |   660,214.4 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,377,346.9 ns | 101,278.46 ns | 5,551.41 ns | 1,372,168.2 ns | 1,383,208.0 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,405.2 ns |   2,691.19 ns |   147.51 ns |   162,236.0 ns |   162,506.4 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,483.9 ns |   1,393.25 ns |    76.37 ns |    91,412.6 ns |    91,564.5 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,518.5 ns |   8,009.45 ns |   439.03 ns |    65,229.4 ns |    66,023.7 ns |      - |      40 B |
