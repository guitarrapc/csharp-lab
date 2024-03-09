```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,346.4 ns** |     **296.46 ns** |     **16.25 ns** |     **1,327.7 ns** |     **1,357.4 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,444.8 ns |      28.96 ns |      1.59 ns |     1,443.0 ns |     1,445.9 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,693.2 ns |      16.63 ns |      0.91 ns |     1,692.5 ns |     1,694.2 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,659.0 ns |     664.39 ns |     36.42 ns |     2,635.7 ns |     2,701.0 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       213.0 ns |      14.83 ns |      0.81 ns |       212.2 ns |       213.8 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       284.9 ns |     100.61 ns |      5.51 ns |       281.6 ns |       291.3 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       490.1 ns |      20.11 ns |      1.10 ns |       489.0 ns |       491.2 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,732.8 ns** |   **2,553.37 ns** |    **139.96 ns** | **1,545,583.0 ns** | **1,545,860.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,295.3 ns |   1,610.75 ns |     88.29 ns |   614,226.5 ns |   614,394.8 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,030.7 ns |  28,418.14 ns |  1,557.69 ns |   655,025.4 ns |   657,825.0 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,385,038.9 ns | 373,465.22 ns | 20,470.89 ns | 1,372,336.3 ns | 1,408,654.0 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,453.9 ns |   5,730.96 ns |    314.13 ns |   162,237.9 ns |   162,814.2 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,478.3 ns |   4,229.26 ns |    231.82 ns |    91,325.8 ns |    91,745.1 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,051.4 ns |   2,431.83 ns |    133.30 ns |    64,928.5 ns |    65,193.1 ns |      - |      40 B |
