using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class UserModel
{
    public int? Id { get; set; }

    private string? _firstName;
    public string? FirstName {
        get { return _firstName; }
        set {
            if (string.IsNullOrEmpty(value?.Trim())) _firstName = null;
            else _firstName = value.Trim();
        }
    }

    private string? _lastName;
    public string? LastName {
        get { return _lastName; }
        set
        {
            if (string.IsNullOrEmpty(value?.Trim())) _lastName = null;
            else _lastName = value.Trim();
        }
    }

    private string? _patronymic;
    public string? Patronymic {
        get { return _patronymic; }
        set
        {
            if (string.IsNullOrEmpty(value?.Trim())) _patronymic = null;
            else _patronymic = value.Trim();
        }
    }

    private string? _DOB;
    public string? DOB {
        get { return _DOB; }
        set
        {
            if (string.IsNullOrEmpty(value?.Trim())) _DOB = null;
            else
            {
                bool parsed = DateTimeOffset.TryParseExact(value, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out var res);
                if (!parsed)
                {
                    res = DateTimeOffset.ParseExact(value, "dd.MM.yyyy", null);
                }

                var resStr = res.ToString("dd.MM.yyyy");
                _DOB = resStr;
            } 
        }
    }

    private string? _email;
    public string? Email {
        get { return _email; }
        set
        {
            if (string.IsNullOrEmpty(value?.Trim())) _email = null;
            else _email = value.Trim();
        }
    }

    private string? _phone;
    public string? Phone {
        get { return _phone; }
        set
        {
            if (string.IsNullOrEmpty(value?.Trim())) _phone = null;
            else _phone = value.Trim();
        }
    }

    private string? _telegram;
    public string? Telegram {
        get { return _telegram; }
        set
        {
            if (string.IsNullOrEmpty(value?.Trim())) _telegram = null;
            else _telegram = value.Trim();
        }
    }

    private string? _university;
    public string? University {
        get { return _university; }
        set
        {
            if (string.IsNullOrEmpty(value?.Trim())) _university = null;
            else _university = value.Trim();
        }
    }

    private string? _country;

    public string? Country {
        get { return _country; }
        set
        {
            if (string.IsNullOrEmpty(value?.Trim())) _country = null;
            else _country = value.Trim();
        }
    }

    private string? _region;

    public string? Region {
        get { return _region; }
        set
        {
            if (string.IsNullOrEmpty(value?.Trim())) _region = null;
            else _region = value.Trim();
        }
    }

    private string? _town;
    public string? Town {
        get { return _town; }
        set
        {
            if (string.IsNullOrEmpty(value?.Trim())) _town = null;
            else _town = value.Trim();
        }
    }

    private string? _street;
    public string? Street {
        get { return _street; }
        set
        {
            if (string.IsNullOrEmpty(value?.Trim())) _street = null;
            else _street = value.Trim();
        }
    }

    private string? _house;
    public string? House {
        get { return _house; }
        set
        {
            if (string.IsNullOrEmpty(value?.Trim())) _house = null;
            else _house = value.Trim();
        }
    }

    private string? _flat;
    public string? Flat {
        get { return _flat; }
        set
        {
            if (string.IsNullOrEmpty(value?.Trim())) _flat = null;
            else _flat = value.Trim();
        }
    }

    private string? _description;
    public string? Description {
        get { return _description; }
        set
        {
            if (string.IsNullOrEmpty(value?.Trim())) _description = null;
            else _description = value.Trim();
        }
    }
}
