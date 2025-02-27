﻿using SQLite;

namespace TeamServer.Storage;

[Table("http_handlers")]
public sealed class HttpHandlerDao
{
    [PrimaryKey, Column("name")]
    public string Name { get; set; }
    
    [Column("bind_port")]
    public int BindPort { get; set; }
    
    [Column("connect_address")]
    public string ConnectAddress { get; set; }
    
    [Column("connect_port")]
    public int ConnectPort { get; set; }
    
    [Column("secure")]
    public bool Secure { get; set; }
}