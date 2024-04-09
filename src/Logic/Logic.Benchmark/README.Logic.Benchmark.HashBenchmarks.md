```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,294.5 ns** |    **120.86 ns** |     **6.62 ns** |     **1,287.3 ns** |     **1,300.4 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,486.4 ns |     74.48 ns |     4.08 ns |     1,481.7 ns |     1,489.2 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,709.1 ns |    472.59 ns |    25.90 ns |     1,686.5 ns |     1,737.4 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,687.6 ns |    802.03 ns |    43.96 ns |     2,658.9 ns |     2,738.2 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       199.0 ns |     16.41 ns |     0.90 ns |       198.3 ns |       200.0 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       282.1 ns |     22.09 ns |     1.21 ns |       280.7 ns |       282.8 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       498.7 ns |    271.50 ns |    14.88 ns |       489.1 ns |       515.9 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,959.4 ns** |    **130.03 ns** |     **7.13 ns** | **1,545,951.2 ns** | **1,545,964.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,303.4 ns |  2,015.95 ns |   110.50 ns |   614,186.0 ns |   614,405.4 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,990.6 ns | 23,700.38 ns | 1,299.10 ns |   654,928.8 ns |   657,439.1 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,378,466.9 ns | 73,560.39 ns | 4,032.09 ns | 1,374,583.1 ns | 1,382,632.5 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   161,650.0 ns | 28,365.64 ns | 1,554.82 ns |   160,429.3 ns |   163,400.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    90,415.4 ns |  3,235.14 ns |   177.33 ns |    90,212.8 ns |    90,542.4 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    64,398.5 ns |  6,397.41 ns |   350.66 ns |    64,155.5 ns |    64,800.5 ns |      - |      40 B |
