create function gen_uuid()
   returns uuid 
   language plpgsql
  as
$$
declare 
   -- variable declaration
begin
	return uuid_in(overlay(overlay(md5(random()::text || ':' || random()::text) placing '4' from 13) placing to_hex(floor(random()*(11-8+1) + 8)::int)::text from 17)::cstring);
end;
$$;